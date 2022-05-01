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
    public partial class formAdminCandidates : Form
    {
        functionCandidate functionCandidate = new functionCandidate();
        private int id;
        public formAdminCandidates()
        {
            InitializeComponent();
        }

        private void formAdminCandidates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingdbDataSet.candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.votingdbDataSet.candidates);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            nameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            positionTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAdminMain formAdminMain = new formAdminMain();
            formAdminMain.ShowDialog();
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();   
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "")
            {
                MessageBox.Show("Select a candidate on the table.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete the candidate", "Delete Candidate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (functionCandidate.deleteCandidate(id))
                    {
                        MessageBox.Show("Candidate Deleted", "Deleted");
                        clearFields();
                        refresh();
                    }
                }
            }
        }

        private void clearFields()
        {
            nameTextBox.Text = "";
            positionTextBox.Text = "";
            searchTextBox.Text = "";
            id = 0;
        }

        private void refresh()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `candidates`");
            DataTable table = functionCandidate.getCandidate(command);

            dataGridView1.DataSource = table;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            formAdminCandidatesAdd formAdminCandidatesAdd = new formAdminCandidatesAdd();
            if (formAdminCandidatesAdd.ShowDialog() == DialogResult.OK)
            {
                clearFields();
                refresh();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            search();
        }


        private void search()
        {
            try
            {
                string input = searchTextBox.Text;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `candidates` WHERE `name` LIKE @input OR `position` LIKE @input");
                command.Parameters.AddWithValue("@input", "%" + input + "%");

                DataTable table = functionCandidate.getCandidate(command);

                dataGridView1.DataSource = table;
                nameTextBox.Text = table.Rows[0]["name"].ToString();
                positionTextBox.Text = table.Rows[0]["position"].ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
