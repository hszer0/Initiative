namespace Initiative
{
    partial class frmAddParticipant
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
            this.lbxToAdd = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.radChar = new System.Windows.Forms.RadioButton();
            this.radNPC = new System.Windows.Forms.RadioButton();
            this.radMon = new System.Windows.Forms.RadioButton();
            this.lbxAdded = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRollInitiative = new System.Windows.Forms.Button();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxToAdd
            // 
            this.lbxToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxToAdd.FormattingEnabled = true;
            this.lbxToAdd.Location = new System.Drawing.Point(11, 35);
            this.lbxToAdd.Name = "lbxToAdd";
            this.lbxToAdd.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxToAdd.Size = new System.Drawing.Size(200, 251);
            this.lbxToAdd.TabIndex = 0;
            this.lbxToAdd.SelectedIndexChanged += new System.EventHandler(this.lbxToAdd_SelectedIndexChanged);
            this.lbxToAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxToAdd_MouseMove);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(221, 76);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnAddAll.TabIndex = 3;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(221, 129);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(221, 158);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // radChar
            // 
            this.radChar.AutoSize = true;
            this.radChar.Location = new System.Drawing.Point(12, 12);
            this.radChar.Name = "radChar";
            this.radChar.Size = new System.Drawing.Size(76, 17);
            this.radChar.TabIndex = 6;
            this.radChar.TabStop = true;
            this.radChar.Text = "Characters";
            this.radChar.UseVisualStyleBackColor = true;
            this.radChar.CheckedChanged += new System.EventHandler(this.radType_CheckedChanged);
            // 
            // radNPC
            // 
            this.radNPC.AutoSize = true;
            this.radNPC.Location = new System.Drawing.Point(94, 12);
            this.radNPC.Name = "radNPC";
            this.radNPC.Size = new System.Drawing.Size(52, 17);
            this.radNPC.TabIndex = 7;
            this.radNPC.TabStop = true;
            this.radNPC.Text = "NPCs";
            this.radNPC.UseVisualStyleBackColor = true;
            this.radNPC.CheckedChanged += new System.EventHandler(this.radType_CheckedChanged);
            // 
            // radMon
            // 
            this.radMon.AutoSize = true;
            this.radMon.Location = new System.Drawing.Point(152, 12);
            this.radMon.Name = "radMon";
            this.radMon.Size = new System.Drawing.Size(68, 17);
            this.radMon.TabIndex = 8;
            this.radMon.TabStop = true;
            this.radMon.Text = "Monsters";
            this.radMon.UseVisualStyleBackColor = true;
            this.radMon.CheckedChanged += new System.EventHandler(this.radType_CheckedChanged);
            // 
            // lbxAdded
            // 
            this.lbxAdded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxAdded.FormattingEnabled = true;
            this.lbxAdded.Location = new System.Drawing.Point(302, 35);
            this.lbxAdded.Name = "lbxAdded";
            this.lbxAdded.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxAdded.Size = new System.Drawing.Size(200, 251);
            this.lbxAdded.TabIndex = 9;
            this.lbxAdded.SelectedIndexChanged += new System.EventHandler(this.lbxAdded_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Participants";
            // 
            // btnRollInitiative
            // 
            this.btnRollInitiative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRollInitiative.Location = new System.Drawing.Point(302, 304);
            this.btnRollInitiative.Name = "btnRollInitiative";
            this.btnRollInitiative.Size = new System.Drawing.Size(197, 23);
            this.btnRollInitiative.TabIndex = 11;
            this.btnRollInitiative.Text = "Roll Initiative";
            this.btnRollInitiative.UseVisualStyleBackColor = true;
            this.btnRollInitiative.Click += new System.EventHandler(this.btnRollInitiative_Click);
            // 
            // txtInit
            // 
            this.txtInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInit.Location = new System.Drawing.Point(65, 306);
            this.txtInit.Name = "txtInit";
            this.txtInit.ReadOnly = true;
            this.txtInit.Size = new System.Drawing.Size(50, 20);
            this.txtInit.TabIndex = 12;
            // 
            // txtDex
            // 
            this.txtDex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDex.Location = new System.Drawing.Point(161, 306);
            this.txtDex.Name = "txtDex";
            this.txtDex.ReadOnly = true;
            this.txtDex.Size = new System.Drawing.Size(50, 20);
            this.txtDex.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dex";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Init Mod";
            // 
            // frmAddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.txtInit);
            this.Controls.Add(this.btnRollInitiative);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxAdded);
            this.Controls.Add(this.radMon);
            this.Controls.Add(this.radNPC);
            this.Controls.Add(this.radChar);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxToAdd);
            this.Name = "frmAddParticipant";
            this.Text = "Add Participants";
            this.Load += new System.EventHandler(this.frmAddParticipant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxToAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.RadioButton radChar;
        private System.Windows.Forms.RadioButton radNPC;
        private System.Windows.Forms.RadioButton radMon;
        private System.Windows.Forms.ListBox lbxAdded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRollInitiative;
        private System.Windows.Forms.TextBox txtInit;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}