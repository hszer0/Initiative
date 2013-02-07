using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Initiative
{
    public partial class frmRollInitiative : Form
    {
        public frmRollInitiative()
        {
            InitializeComponent();
        }

        private void frmRollInitiative_Load(object sender, EventArgs e)
        {
            //datagrid vullen

            foreach (DataRow row in Globals.dtInitiative.Rows)
	        {
                dgvCombatants.Rows.Add(row["Name"], null, row["Init"], row["Dex"]);
	        }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
