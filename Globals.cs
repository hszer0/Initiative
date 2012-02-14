using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Initiative
{
    static class Globals
    {
        private static ApplicationSettings applicationsettings = new ApplicationSettings();

        private static DataTable dtinitiative = new DataTable();

        public static DataTable dtInitiative
        {
            get { return dtinitiative; }
            set { dtinitiative = value; }
        }

        public static ApplicationSettings Applicationsettings
        {
            get { return applicationsettings; }
            set { applicationsettings = value; }
        } 

    }
}
