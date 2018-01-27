using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace GlobalGameJam2018
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Data\Nintendo-NES-Font.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            }
            btn1PlayerStart.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            btn2PlayerStart.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            btnExitGame.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            btnInstructions.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Instructions viewInstructions = new Instructions();
            if (viewInstructions.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1PlayerStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerSelection OnePlayerGame = new PlayerSelection();
            OnePlayerGame.Closed += (s, args) => this.Close();
            OnePlayerGame.Show();
        }

        private void btn2PlayerStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerSelection TwoPlayerGame = new PlayerSelection(true);
            TwoPlayerGame.Closed += (s, args) => this.Close();
            TwoPlayerGame.Show();
        }
    }
}
