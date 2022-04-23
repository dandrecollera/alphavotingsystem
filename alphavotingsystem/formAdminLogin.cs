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
    public partial class formAdminLogin : Form
    {
        dbConnection db = new dbConnection();
        public formAdminLogin()
        {
            InitializeComponent();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin_accounts` WHERE `username` = @username AND `password` = @password", db.GetConnection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = usernameTextBox.Text.Trim();
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordTextBox.Text.Trim();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                formAdminMain formAdminMain = new formAdminMain();
                formAdminMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void returnLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formRegister formRegister = new formRegister();
            formRegister.ShowDialog();
            this.Close();
        }
    }
}
