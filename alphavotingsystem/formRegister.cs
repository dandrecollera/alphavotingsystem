using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alphavotingsystem
{
    public partial class formRegister : Form
    {
        functionSettings student = new functionSettings();


        public formRegister()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (studentIDTextBox.Text == "" || studentNameTextBox.Text == "" || studentYearComboBox.Text == "" || studentStrandComboBox.Text == "" || studentSectionComboBox.Text == "")
            {
                student.inputSettings(studentIDTextBox.Text, studentNameTextBox.Text, studentYearComboBox.Text, studentStrandComboBox.Text, studentSectionComboBox.Text);

                this.Hide();
                formMain formMain = new formMain();
                formMain.ShowDialog();
                this.Close();
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
    }
}
