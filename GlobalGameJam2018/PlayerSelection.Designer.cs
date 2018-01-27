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
            this.components = new System.ComponentModel.Container();
            this.pbxWizard = new System.Windows.Forms.PictureBox();
            this.pbxElf = new System.Windows.Forms.PictureBox();
            this.pbxWarrior = new System.Windows.Forms.PictureBox();
            this.lblPlayerSelectTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCharacterType = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxElf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarrior)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxWizard
            // 
            this.pbxWizard.BackColor = System.Drawing.Color.Cyan;
            this.pbxWizard.Location = new System.Drawing.Point(210, 76);
            this.pbxWizard.Name = "pbxWizard";
            this.pbxWizard.Size = new System.Drawing.Size(175, 250);
            this.pbxWizard.TabIndex = 0;
            this.pbxWizard.TabStop = false;
            // 
            // pbxElf
            // 
            this.pbxElf.BackColor = System.Drawing.Color.LimeGreen;
            this.pbxElf.Location = new System.Drawing.Point(690, 76);
            this.pbxElf.Name = "pbxElf";
            this.pbxElf.Size = new System.Drawing.Size(175, 250);
            this.pbxElf.TabIndex = 1;
            this.pbxElf.TabStop = false;
            // 
            // pbxWarrior
            // 
            this.pbxWarrior.BackColor = System.Drawing.Color.Crimson;
            this.pbxWarrior.Location = new System.Drawing.Point(400, 129);
            this.pbxWarrior.Name = "pbxWarrior";
            this.pbxWarrior.Size = new System.Drawing.Size(275, 350);
            this.pbxWarrior.TabIndex = 2;
            this.pbxWarrior.TabStop = false;
            // 
            // lblPlayerSelectTitle
            // 
            this.lblPlayerSelectTitle.AutoSize = true;
            this.lblPlayerSelectTitle.Font = new System.Drawing.Font("Nintendo NES Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerSelectTitle.Location = new System.Drawing.Point(297, 28);
            this.lblPlayerSelectTitle.Name = "lblPlayerSelectTitle";
            this.lblPlayerSelectTitle.Size = new System.Drawing.Size(472, 16);
            this.lblPlayerSelectTitle.TabIndex = 3;
            this.lblPlayerSelectTitle.Text = "PLAYER 1: CHARACTER SELECTION";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(174, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 73);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "V";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(826, 356);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 73);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCharacterType
            // 
            this.btnCharacterType.Location = new System.Drawing.Point(400, 486);
            this.btnCharacterType.Name = "btnCharacterType";
            this.btnCharacterType.Size = new System.Drawing.Size(275, 41);
            this.btnCharacterType.TabIndex = 6;
            this.btnCharacterType.Text = "CHARACTER TYPE";
            this.btnCharacterType.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 563);
            this.Controls.Add(this.btnCharacterType);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlayerSelectTitle);
            this.Controls.Add(this.pbxWarrior);
            this.Controls.Add(this.pbxElf);
            this.Controls.Add(this.pbxWizard);
            this.Name = "PlayerSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerSelection";
            this.Load += new System.EventHandler(this.PlayerSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxWizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxElf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWarrior)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
    }
}