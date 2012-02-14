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
    public partial class ParticipantManagement : Form
    {
        private DataRow row;

        public ParticipantManagement()
        {
            InitializeComponent();
        }

        private void btnCharClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radType_CheckedChanged(object sender, EventArgs e)
        {
            rebuildList();
        }

        private void rebuildList()
        {
            listBoxChar.Items.Clear();
            string type;
            if (radMonsters.Checked)
                type = "M";
            else if (radCharacters.Checked)
                type = "C";
            else
                type = "N";

            if (Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Count != 0)
            {
                foreach (DataRow row in Globals.Applicationsettings.Participants.Tables["Participants"].Rows)
                {
                    if (row["type"].ToString() == type)
                        listBoxChar.Items.Add(row["Name"]);
                }
            }

            foreach (Control c in this.Controls)
                if (c is TextBox && c.Name != "txtNewName")
                    (c as TextBox).Clear();
            listBoxChar.Refresh();
            listBoxChar.SelectedIndex = -1;
            btnCharDelete.Enabled = false;
            btnCharSave.Enabled = false;
        }

        private void listBoxChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxChar.SelectedIndex >= 0)
            {
                row = Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Find(listBoxChar.SelectedItem.ToString());
                if (row != null)
                {
                    txtName.Text = row["Name"].ToString();
                    txtInit.Text = row["Init"].ToString();
                    txtDex.Text = row["Dex"].ToString();
                }

                btnCharDelete.Enabled = true;
                btnCharSave.Enabled = true;
                txtNewName.Text = "";
            }
        }

        private void btnCharDelete_Click(object sender, EventArgs e)
        {
            row = Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Find(txtName.Text);
            Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Remove(row);
            rebuildList();
        }

        private void btnCharSave_Click(object sender, EventArgs e)
        {
            SaveParticipant();
            rebuildList();
            txtNewName.Focus();
        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {
            btnCharAdd.Enabled = !(txtNewName.Text == "");
        }

        private void ParticipantManagement_Load(object sender, EventArgs e)
        {
            radCharacters.Checked = true;
        }

        private void btnCharAdd_Click(object sender, EventArgs e)
        {
            string name = txtNewName.Text;
            string type;
            if (radMonsters.Checked)
                type = "M";
            else if (radCharacters.Checked)
                type = "C";
            else
                type = "N";

            DataRow row = Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Find(name);
            if (row == null)
            {
                Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Add(name, type, 0, 0);
                rebuildList();
                btnCharAdd.Enabled = false;
                listBoxChar.SelectedIndex = listBoxChar.Items.IndexOf(name);
                txtDex.Focus();
                txtDex.SelectAll();
            }
            else
            {
                MessageBox.Show("Error: Duplicate Name. Monster/NPC/Character names should be unique.");
                txtNewName.Focus();
                txtNewName.SelectAll();
            }
        }

        private void ParticipantManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.Applicationsettings.SaveAppSettings();
        }

        private bool SaveParticipant()
        {
            try
            {
                Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Find(listBoxChar.SelectedItem.ToString())["Name"] = txtName.Text;
            }
            catch
            {
                MessageBox.Show("Error: Duplicate Name. Monster/NPC/Character names should be unique.");
                txtName.Focus();
                txtName.SelectAll();
                return false;
            }

            try
            {
                Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Find(listBoxChar.SelectedItem.ToString())["Dex"] = Convert.ToInt32(txtDex.Text);
                Globals.Applicationsettings.Participants.Tables["Participants"].Rows.Find(listBoxChar.SelectedItem.ToString())["Init"] = Convert.ToInt32(txtInit.Text);
            }
            catch
            {
                MessageBox.Show("Error: Invalid Dex or Init format. Only integers are allowed.");
                return false;
            }

            return true;
        }
    }
}
