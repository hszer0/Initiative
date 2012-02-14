namespace Initiative
{
    partial class ParticipantManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxChar = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCharAdd = new System.Windows.Forms.Button();
            this.btnCharDelete = new System.Windows.Forms.Button();
            this.btnCharClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCharSave = new System.Windows.Forms.Button();
            this.radCharacters = new System.Windows.Forms.RadioButton();
            this.radMonsters = new System.Windows.Forms.RadioButton();
            this.radNPCs = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBoxChar
            // 
            this.listBoxChar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxChar.FormattingEnabled = true;
            this.listBoxChar.Location = new System.Drawing.Point(258, 35);
            this.listBoxChar.Name = "listBoxChar";
            this.listBoxChar.Size = new System.Drawing.Size(202, 303);
            this.listBoxChar.Sorted = true;
            this.listBoxChar.TabIndex = 9;
            this.listBoxChar.TabStop = false;
            this.listBoxChar.SelectedIndexChanged += new System.EventHandler(this.listBoxChar_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dexterity";
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(102, 139);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(72, 20);
            this.txtDex.TabIndex = 4;
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(102, 165);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(72, 20);
            this.txtInit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Initiative Mod";
            // 
            // btnCharAdd
            // 
            this.btnCharAdd.Enabled = false;
            this.btnCharAdd.Location = new System.Drawing.Point(102, 43);
            this.btnCharAdd.Name = "btnCharAdd";
            this.btnCharAdd.Size = new System.Drawing.Size(150, 23);
            this.btnCharAdd.TabIndex = 2;
            this.btnCharAdd.Text = "Add";
            this.btnCharAdd.UseVisualStyleBackColor = true;
            this.btnCharAdd.Click += new System.EventHandler(this.btnCharAdd_Click);
            // 
            // btnCharDelete
            // 
            this.btnCharDelete.Enabled = false;
            this.btnCharDelete.Location = new System.Drawing.Point(102, 220);
            this.btnCharDelete.Name = "btnCharDelete";
            this.btnCharDelete.Size = new System.Drawing.Size(150, 23);
            this.btnCharDelete.TabIndex = 7;
            this.btnCharDelete.Text = "Delete";
            this.btnCharDelete.UseVisualStyleBackColor = true;
            this.btnCharDelete.Click += new System.EventHandler(this.btnCharDelete_Click);
            // 
            // btnCharClose
            // 
            this.btnCharClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCharClose.Location = new System.Drawing.Point(369, 351);
            this.btnCharClose.Name = "btnCharClose";
            this.btnCharClose.Size = new System.Drawing.Size(93, 23);
            this.btnCharClose.TabIndex = 10;
            this.btnCharClose.TabStop = false;
            this.btnCharClose.Text = "Close";
            this.btnCharClose.UseVisualStyleBackColor = true;
            this.btnCharClose.Click += new System.EventHandler(this.btnCharClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "New Name";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(102, 17);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(150, 20);
            this.txtNewName.TabIndex = 1;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "______________________________________";
            // 
            // btnCharSave
            // 
            this.btnCharSave.Enabled = false;
            this.btnCharSave.Location = new System.Drawing.Point(102, 191);
            this.btnCharSave.Name = "btnCharSave";
            this.btnCharSave.Size = new System.Drawing.Size(150, 23);
            this.btnCharSave.TabIndex = 6;
            this.btnCharSave.Text = "Save";
            this.btnCharSave.UseVisualStyleBackColor = true;
            this.btnCharSave.Click += new System.EventHandler(this.btnCharSave_Click);
            // 
            // radCharacters
            // 
            this.radCharacters.AutoSize = true;
            this.radCharacters.Location = new System.Drawing.Point(258, 12);
            this.radCharacters.Name = "radCharacters";
            this.radCharacters.Size = new System.Drawing.Size(76, 17);
            this.radCharacters.TabIndex = 0;
            this.radCharacters.Text = "Characters";
            this.radCharacters.UseVisualStyleBackColor = true;
            this.radCharacters.CheckedChanged += new System.EventHandler(this.radType_CheckedChanged);
            // 
            // radMonsters
            // 
            this.radMonsters.AutoSize = true;
            this.radMonsters.Location = new System.Drawing.Point(390, 12);
            this.radMonsters.Name = "radMonsters";
            this.radMonsters.Size = new System.Drawing.Size(68, 17);
            this.radMonsters.TabIndex = 8;
            this.radMonsters.Text = "Monsters";
            this.radMonsters.UseVisualStyleBackColor = true;
            this.radMonsters.CheckedChanged += new System.EventHandler(this.radType_CheckedChanged);
            // 
            // radNPCs
            // 
            this.radNPCs.AutoSize = true;
            this.radNPCs.Location = new System.Drawing.Point(332, 12);
            this.radNPCs.Name = "radNPCs";
            this.radNPCs.Size = new System.Drawing.Size(52, 17);
            this.radNPCs.TabIndex = 13;
            this.radNPCs.Text = "NPCs";
            this.radNPCs.UseVisualStyleBackColor = true;
            this.radNPCs.CheckedChanged += new System.EventHandler(this.radType_CheckedChanged);
            // 
            // ParticipantManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 384);
            this.Controls.Add(this.radNPCs);
            this.Controls.Add(this.radMonsters);
            this.Controls.Add(this.radCharacters);
            this.Controls.Add(this.btnCharSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.btnCharClose);
            this.Controls.Add(this.btnCharDelete);
            this.Controls.Add(this.btnCharAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInit);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listBoxChar);
            this.Name = "ParticipantManagement";
            this.Text = "Participant Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParticipantManagement_FormClosing);
            this.Load += new System.EventHandler(this.ParticipantManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtInit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCharAdd;
        private System.Windows.Forms.Button btnCharDelete;
        private System.Windows.Forms.Button btnCharClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCharSave;
        private System.Windows.Forms.RadioButton radCharacters;
        private System.Windows.Forms.RadioButton radMonsters;
        private System.Windows.Forms.RadioButton radNPCs;
    }
}