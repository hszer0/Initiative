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
    public partial class frmAddParticipant : Form
    {
        public frmAddParticipant()
        {
            InitializeComponent();
        }

        private void rebuildList()
        {
            lbxAdded.Items.Clear();
            foreach (DataRow participant in Globals.dtInitiative.Rows)
            {
                lbxAdded.Items.Add(participant["Name"]);
            }

            lbxAdded.Refresh();
            lbxAdded.SelectedIndex = -1;
            lbxToAdd.Items.Clear();
            string type;
            if (radMon.Checked)
                type = "M";
            else if (radChar.Checked)
                type = "C";
            else
                type = "N";

            if (Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Count != 0)
            {
                foreach (DataRow row in Globals.Applicationsettings.Participants.Tables["Participants"].Rows)
                {
                    if (row["Type"].ToString() == type && !lbxAdded.Items.Contains(row["Name"]))
                    {
                        lbxToAdd.Items.Add(row["Name"]);
                    }
                }
            }

            lbxToAdd.Refresh();
            lbxToAdd.SelectedIndex = -1;
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void radType_CheckedChanged(object sender, EventArgs e)
        {
            btnAddAll.Enabled = !radMon.Checked;
            rebuildList();
        }

        private void lbxToAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is ListBox)
            {
                ListBox listBox = (ListBox)sender;
                Point point = new Point(e.X, e.Y);
                int hoverIndex = listBox.IndexFromPoint(point);

                if (hoverIndex >= 0 && hoverIndex < listBox.Items.Count)
                {
                    DataRow row = Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Find(lbxToAdd.Items[hoverIndex].ToString());
                    if (row != null)
                    {
                        txtDex.Text = row["Dex"].ToString();
                        txtInit.Text = row["Init"].ToString();
                    }
                }
                else
                {
                    txtDex.Text = "";
                    txtInit.Text = "";
                }
            }
        }

        private void frmAddParticipant_Load(object sender, EventArgs e)
        {
            Globals.dtInitiative.Rows.Clear();
            radChar.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            foreach (object item in lbxToAdd.SelectedItems)
            {
                 DataRow row = Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Find(item.ToString());
                 if (row != null)
                 {
                     name = row["Name"].ToString();
                     if (row["Type"].ToString() == "M")
                     {
                         int i;
                         for (i = 1; lbxAdded.Items.Contains(row["Name"] + " " + i.ToString()); i++) ;
                         name = row["Name"] + " " + i.ToString();
                     }
                     Globals.dtInitiative.Rows.Add(name, row["Type"].ToString(), (int)row["Init"], (int)row["Dex"]);
                 }
            }

            rebuildList();
        }

        private void lbxToAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (lbxToAdd.SelectedItems.Count > 0);
        }

        private void lbxAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (lbxAdded.SelectedItems.Count > 0);
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbxToAdd.Items.Count; i++)
			{
                lbxToAdd.SetSelected(i, true);
			}
            btnAdd_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (object item in lbxAdded.SelectedItems)
            {
                DataRow row = Globals.dtInitiative.Rows.Find(item.ToString());
                Globals.dtInitiative.Rows.Remove(row);
            }
            rebuildList();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            Globals.dtInitiative.Rows.Clear();
            rebuildList();
        }

        private void btnRollInitiative_Click(object sender, EventArgs e)
        {
            //roll initiative on next form
            frmRollInitiative RIForm = new frmRollInitiative();
            RIForm.Show();
            this.Close();
        }
    }
}
