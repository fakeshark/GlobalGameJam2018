namespace GlobalGameJam2018
{
    partial class SplashScreen
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
            this.btn1PlayerStart = new System.Windows.Forms.Button();
            this.btn2PlayerStart = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.pnlSplash = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn1PlayerStart
            // 
            this.btn1PlayerStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn1PlayerStart.Location = new System.Drawing.Point(57, 487);
            this.btn1PlayerStart.Name = "btn1PlayerStart";
            this.btn1PlayerStart.Size = new System.Drawing.Size(304, 52);
            this.btn1PlayerStart.TabIndex = 1;
            this.btn1PlayerStart.Text = "1P. START";
            this.btn1PlayerStart.UseVisualStyleBackColor = true;
            this.btn1PlayerStart.Click += new System.EventHandler(this.btn1PlayerStart_Click);
            // 
            // btn2PlayerStart
            // 
            this.btn2PlayerStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn2PlayerStart.Location = new System.Drawing.Point(371, 487);
            this.btn2PlayerStart.Name = "btn2PlayerStart";
            this.btn2PlayerStart.Size = new System.Drawing.Size(304, 52);
            this.btn2PlayerStart.TabIndex = 2;
            this.btn2PlayerStart.Text = "2P. START";
            this.btn2PlayerStart.UseVisualStyleBackColor = true;
            this.btn2PlayerStart.Click += new System.EventHandler(this.btn2PlayerStart_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInstructions.Location = new System.Drawing.Point(685, 487);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(304, 52);
            this.btnInstructions.TabIndex = 3;
            this.btnInstructions.Text = "INSTRUCTIONS";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitGame.Location = new System.Drawing.Point(804, 554);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(185, 45);
            this.btnExitGame.TabIndex = 4;
            this.btnExitGame.Text = "EXIT GAME";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlSplash
            // 
            this.pnlSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSplash.BackColor = System.Drawing.Color.Black;
            this.pnlSplash.BackgroundImage = global::GlobalGameJam2018.Properties.Resources.sword;
            this.pnlSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlSplash.Location = new System.Drawing.Point(57, 75);
            this.pnlSplash.Name = "pnlSplash";
            this.pnlSplash.Size = new System.Drawing.Size(932, 323);
            this.pnlSplash.TabIndex = 0;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::GlobalGameJam2018.Properties.Resources.panelBlack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 670);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btn2PlayerStart);
            this.Controls.Add(this.btn1PlayerStart);
            this.Controls.Add(this.pnlSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSplash;
        private System.Windows.Forms.Button btn1PlayerStart;
        private System.Windows.Forms.Button btn2PlayerStart;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnExitGame;
    }
}