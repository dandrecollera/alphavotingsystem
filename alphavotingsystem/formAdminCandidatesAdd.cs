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
    public partial class formAdminCandidatesAdd : Form
    {
        functionCandidate functionCandidate = new functionCandidate();
        public formAdminCandidatesAdd()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text != "" && positionComboBox.SelectedIndex != -1)
            {
                if (MessageBox.Show("Do you want to add the candidate", "Add Candidate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(functionCandidate.insertCandidate(nameTextBox.Text, positionComboBox.Text, 0))
                    {
                        MessageBox.Show("Candidate Added", "Added");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Input name and position.", "Invalid Input", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
    }
}
