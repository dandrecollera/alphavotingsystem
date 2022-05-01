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
    public partial class formAdminVoters : Form
    {
        public formAdminVoters()
        {
            InitializeComponent();
        }

        private void formAdminVoters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingdbDataSet.voters' table. You can move, or remove it, as needed.
            this.votersTableAdapter.Fill(this.votingdbDataSet.voters);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAdminMain formAdminMain = new formAdminMain();
            formAdminMain.ShowDialog();
            this.Close();
        }
    }
}
