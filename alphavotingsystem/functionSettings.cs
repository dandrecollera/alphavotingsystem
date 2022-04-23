using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphavotingsystem
{
    class functionSettings
    {

        public string id()
        {
            return Properties.Settings.Default.studentID;
        }
        public string name()
        {
            return Properties.Settings.Default.studentName;
        }
        public string year()
        {
            return Properties.Settings.Default.studentYear;
        }
        public string strand()
        {
            return Properties.Settings.Default.studentStrand;
        }
        public string section()
        {
            return Properties.Settings.Default.studentSection;
        }

        public void inputSettings(string id, string name, string year, string strand, string section)
        {
            Properties.Settings.Default.studentID = id;
            Properties.Settings.Default.studentName = name;
            Properties.Settings.Default.studentYear = year;
            Properties.Settings.Default.studentStrand = strand;
            Properties.Settings.Default.studentSection = section;
        }

        public void clearSettings()
        {
            Properties.Settings.Default.studentID = "" ;
            Properties.Settings.Default.studentName = "";
            Properties.Settings.Default.studentYear = "";
            Properties.Settings.Default.studentStrand = "";
            Properties.Settings.Default.studentSection = "";
        }
    }
}
