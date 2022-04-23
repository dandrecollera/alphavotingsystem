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
    public partial class formMain : Form
    {
        formRegister formRegister = new formRegister();
        functionSettings student = new functionSettings();
        public formMain()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            student.clearSettings();
            formRegister.ShowDialog();
            this.Close();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingdbDataSet.candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.votingdbDataSet.candidates);

        }
    }
}
