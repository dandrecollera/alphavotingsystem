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
    public partial class formAdminMain : Form
    {
        public formAdminMain()
        {
            InitializeComponent();
        }

        private void formAdminMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votingdbDataSet.candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.votingdbDataSet.candidates);

        }
    }
}
