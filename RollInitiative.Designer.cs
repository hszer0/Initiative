namespace Initiative
{
    partial class frmRollInitiative
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
            this.dgvCombatants = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Initiative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombatants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCombatants
            // 
            this.dgvCombatants.AllowUserToResizeColumns = false;
            this.dgvCombatants.AllowUserToResizeRows = false;
            this.dgvCombatants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCombatants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombatants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.Initiative,
            this.InitMod,
            this.Dex});
            this.dgvCombatants.Location = new System.Drawing.Point(12, 12);
            this.dgvCombatants.Name = "dgvCombatants";
            this.dgvCombatants.Size = new System.Drawing.Size(458, 396);
            this.dgvCombatants.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(479, 385);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Combat!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fill in each combatant\'s initiative score. \r\nLeave blank to roll automatically.\r\n" +
    "\r\nYou can add, remove and edit entries\r\nin this grid. When you\'re finished,\r\npre" +
    "ss \"Start Combat\".";
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Width = 200;
            // 
            // Initiative
            // 
            this.Initiative.HeaderText = "Initiative Total";
            this.Initiative.Name = "Initiative";
            this.Initiative.Width = 70;
            // 
            // InitMod
            // 
            this.InitMod.HeaderText = "Init Mod";
            this.InitMod.Name = "InitMod";
            this.InitMod.Width = 70;
            // 
            // Dex
            // 
            this.Dex.HeaderText = "Dex";
            this.Dex.Name = "Dex";
            this.Dex.Width = 70;
            // 
            // frmRollInitiative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvCombatants);
            this.Name = "frmRollInitiative";
            this.Text = "Roll Initiative";
            this.Load += new System.EventHandler(this.frmRollInitiative_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombatants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCombatants;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Initiative;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dex;
    }
}