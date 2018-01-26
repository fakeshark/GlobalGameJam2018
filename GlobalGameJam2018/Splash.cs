using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GlobalGameJam2018
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.DimGray;
            this.TransparencyKey = Color.DimGray;
            InitializeComponent();
            // make background music for the splash screen
        }

        private void btnOnePlayerStart_Click(object sender, EventArgs e)
        {
            //Launch mainGame form for 1 player game
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Launch mainGame form for 2 player game
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Launch instructions form but leave this form open
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }
    }
}
