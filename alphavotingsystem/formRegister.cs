using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace alphavotingsystem
{
    public partial class formRegister : Form
    {
        functionSettings student = new functionSettings();
        dbConnection db = new dbConnection();

        public formRegister()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (studentIDTextBox.Text != "" && studentNameTextBox.Text != "" && studentYearComboBox.Text != "" && studentStrandComboBox.SelectedIndex != -1 && studentSectionComboBox.SelectedIndex != -1)
            {
                if (checkVoters(studentIDTextBox.Text))
                {
                    MessageBox.Show("Student already voted", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    student.clearSettings();
                }
                else
                {
                    student.inputSettings(studentIDTextBox.Text, studentNameTextBox.Text, studentYearComboBox.Text, studentStrandComboBox.Text, studentSectionComboBox.Text);

                    this.Hide();
                    formMain formMain = new formMain();
                    formMain.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input", "Enter all fields.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formAdminLogin formAdminLogin = new formAdminLogin();
            formAdminLogin.ShowDialog();
            this.Close();
        }

        private bool checkVoters(string studentId)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `voters` WHERE `student_id` = @student_id", db.GetConnection);
            command.Parameters.Add("@student_id", MySqlDbType.VarChar).Value = studentId;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
