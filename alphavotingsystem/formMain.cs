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
        functionVotes functionVotes = new functionVotes();
        public DataTable[] positions = new DataTable[7];
        public formMain()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            toRegister();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            fillPosition();
            fillBox();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (presidentComboBox.SelectedIndex != -1 && vicePresidentComboBox.SelectedIndex != -1 && secretaryComboBox.SelectedIndex != -1 && treasurerComboBox.SelectedIndex != -1 && auditorComboBox.SelectedIndex != -1 && projectManagerComboBox.SelectedIndex != -1 && pioComboBox.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure to vote?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int[] id = getInfo("id");
                    int[] votes = getInfo("votes");
                    functionVotes.updateVotes(id, votes);
                    functionVotes.addHistory();
                    MessageBox.Show("Vote Registered", "Thank You");                   
                    toRegister();                    
                }
            }
        }


        private void fillPosition()
        {
            string[] pos = new string[7] { "president", "vicePresident", "secretary", "treasurer", "auditor", "projectManager", "pio" };
            string[] posProper = new string[7] { "President", "Vice President", "Secretary", "Treasurer", "Auditor", "Project Manager", "PIO" };
            for(int x = 0; x < 7; x++)
            {
                positions[x] = new DataTable(pos[x]);
                positions[x] = functionVotes.getPositions(posProper[x]);

            }

        }

        private void fillBox()
        {
            int x = 0;
            foreach(Control foo in panel1.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if(foo is ComboBox box)
                {
                    box.DataSource = positions[x];
                    x++;
                }
            }
        }

        private int[] getInfo(string data)
        {
            int[] foo = new int[7];
            List<ComboBox> controls = new List<ComboBox>();
            foreach(Control con in panel1.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if(con is ComboBox box)
                {
                    controls.Add(box);
                }
            }

            for(int x = 0; x < 7; x++)
            {
                foo[x] = Convert.ToInt32(positions[x].Rows[controls[x].SelectedIndex][data]);
                Console.WriteLine(foo[x]);
            }

            return foo;
        }

        private void toRegister()
        {
            this.Hide();
            student.clearSettings();
            formRegister.ShowDialog();
            this.Close();
        }
    }
}
