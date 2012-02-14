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
    public partial class Main : Form
    {
        DataSet Participants;

        public string sStatusBar
        {
            get
            {
                return this.statusStrip.Text;
            }
            set
            {
                this.statusStrip.Text = value;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ProductName + " v. " + this.ProductVersion + "\nby " + this.CompanyName);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Globals.Applicationsettings.LoadAppSettings())
            {
                this.Size = Globals.Applicationsettings.FormSize;
                this.Location = Globals.Applicationsettings.FormLocation;
                this.Participants = Globals.Applicationsettings.Participants;
                report("Settings loaded!");
            }
            else
            {
                report("Warning! No settings detected! New settings created.");
            }

            DataColumn name = new DataColumn("Name", typeof(string));
            DataColumn[] keys = new DataColumn[1];
            keys[0] = name;
            Globals.dtInitiative.Columns.Add(name);
            Globals.dtInitiative.Columns.Add("Type", typeof(string));
            Globals.dtInitiative.Columns.Add("Init", typeof(int));
            Globals.dtInitiative.Columns.Add("Dex", typeof(int));
            Globals.dtInitiative.Columns.Add("InitScore", typeof(int));
            Globals.dtInitiative.Columns.Add("Order", typeof(int));
            Globals.dtInitiative.PrimaryKey = keys;
        }

        private void Main_LocationChanged(object sender, EventArgs e)
        {
            Globals.Applicationsettings.FormLocation = this.Location;
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            Globals.Applicationsettings.FormSize = this.Size;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.Applicationsettings.SaveAppSettings())
            {
                report("Settings saved!");
            }
            else
            {
                report("Saving failed!");
            }
        }

        private void report(string message)
        {
            this.toolStripStatusLabel1.Text = message;
        }

        private void newCombatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Participants = Globals.Applicationsettings.Participants;
            if (Participants.Tables["Participants"].Rows.Count == 0)
            {
                report("Create participants first!");
            }
            else
            {
                frmAddParticipant APForm = new frmAddParticipant();
                APForm.Show();
            }

        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParticipantManagement CMForm = new ParticipantManagement();
            CMForm.Show();
        }
    }
}
