namespace GlobalGameJam2018
{
    partial class PlayerSelection
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
            this.lblPlayerSelectTitle = new System.Windows.Forms.Label();
            this.btnCharacterType = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbxWarrior = new System.Windows.Forms.PictureBox();
            this.pbxElf = new System.Windows.Forms.PictureBox();
            this.pbxWizard = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxElf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWizard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerSelectTitle
            // 
            this.lblPlayerSelectTitle.AutoSize = true;
            this.lblPlayerSelectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerSelectTitle.Font = new System.Drawing.Font("Nintendo NES Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerSelectTitle.ForeColor = System.Drawing.Color.White;
            this.lblPlayerSelectTitle.Location = new System.Drawing.Point(297, 59);
            this.lblPlayerSelectTitle.Name = "lblPlayerSelectTitle";
            this.lblPlayerSelectTitle.Size = new System.Drawing.Size(472, 16);
            this.lblPlayerSelectTitle.TabIndex = 3;
            this.lblPlayerSelectTitle.Text = "PLAYER 1: CHARACTER SELECTION";
            // 
            // btnCharacterType
            // 
            this.btnCharacterType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCharacterType.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCharacterType.FlatAppearance.BorderSize = 0;
            this.btnCharacterType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCharacterType.Font = new System.Drawing.Font("Nintendo NES Font", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharacterType.Image = global::GlobalGameJam2018.Properties.Resources.wideButton;
            this.btnCharacterType.Location = new System.Drawing.Point(416, 482);
            this.btnCharacterType.Name = "btnCharacterType";
            this.btnCharacterType.Size = new System.Drawing.Size(275, 80);
            this.btnCharacterType.TabIndex = 6;
            this.btnCharacterType.Text = "WARRIOR";
            this.btnCharacterType.UseVisualStyleBackColor = true;
            this.btnCharacterType.Click += new System.EventHandler(this.btnCharacterType_Click);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Image = global::GlobalGameJam2018.Properties.Resources.nextArrow;
            this.btnNext.Location = new System.Drawing.Point(837, 356);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 73);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = global::GlobalGameJam2018.Properties.Resources.backArrow;
            this.btnBack.Location = new System.Drawing.Point(193, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 73);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbxWarrior
            // 
            this.pbxWarrior.BackColor = System.Drawing.Color.Transparent;
            this.pbxWarrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWarrior.Image = global::GlobalGameJam2018.Properties.Resources.warriorSelect;
            this.pbxWarrior.Location = new System.Drawing.Point(416, 114);
            this.pbxWarrior.Name = "pbxWarrior";
            this.pbxWarrior.Size = new System.Drawing.Size(275, 350);
            this.pbxWarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWarrior.TabIndex = 2;
            this.pbxWarrior.TabStop = false;
            this.pbxWarrior.Tag = "WARRIOR";
            // 
            // pbxElf
            // 
            this.pbxElf.BackColor = System.Drawing.Color.Transparent;
            this.pbxElf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxElf.Enabled = false;
            this.pbxElf.Image = global::GlobalGameJam2018.Properties.Resources.elfSelect;
            this.pbxElf.Location = new System.Drawing.Point(737, 76);
            this.pbxElf.Name = "pbxElf";
            this.pbxElf.Size = new System.Drawing.Size(175, 250);
            this.pbxElf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxElf.TabIndex = 1;
            this.pbxElf.TabStop = false;
            this.pbxElf.Tag = "ELF";
            // 
            // pbxWizard
            // 
            this.pbxWizard.BackColor = System.Drawing.Color.Transparent;
            this.pbxWizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxWizard.Enabled = false;
            this.pbxWizard.Image = global::GlobalGameJam2018.Properties.Resources.wizardSelect;
            this.pbxWizard.Location = new System.Drawing.Point(193, 76);
            this.pbxWizard.Name = "pbxWizard";
            this.pbxWizard.Size = new System.Drawing.Size(175, 250);
            this.pbxWizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWizard.TabIndex = 0;
            this.pbxWizard.TabStop = false;
            this.pbxWizard.Tag = "WIZARD";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::GlobalGameJam2018.Properties.Resources.panelBlack;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 602);
            this.panel1.TabIndex = 7;
            // 
            // PlayerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1104, 626);
            this.Controls.Add(this.btnCharacterType);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlayerSelectTitle);
            this.Controls.Add(this.pbxWarrior);
            this.Controls.Add(this.pbxElf);
            this.Controls.Add(this.pbxWizard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerSelection";
            this.Load += new System.EventHandler(this.PlayerSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxElf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWizard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxWizard;
        private System.Windows.Forms.PictureBox pbxElf;
        private System.Windows.Forms.PictureBox pbxWarrior;
        private System.Windows.Forms.Label lblPlayerSelectTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCharacterType;
        private System.Windows.Forms.Panel panel1;
    }
}