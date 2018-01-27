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
    public partial class PlayerSelection : Form
    {
        bool moveLeft = false;
        bool moveRight = false;
        int wizard_x, wizard_y, elf_x, elf_y, warrior_x, warrior_y;
        int[] leftLocation = new int[] { 193, 76 };
        int[] rightLocation = new int[] { 737, 76 };
        int[] centerLocation = new int[] { 416, 114 };
        PictureBox[] characters = new PictureBox[] { };

        public PlayerSelection()
        {
            InitializeComponent();
            characters = new PictureBox[] { pbxWizard, pbxElf, pbxWarrior };
        }

        public PlayerSelection(bool  twoPlayerGame)
        {
            InitializeComponent();
            MessageBox.Show("2 player Game");
        }

        private void btnCharacterType_Click(object sender, EventArgs e)
        {
            SplashScreen.bgm.controls.stop();
            string selectedCharacter = btnCharacterType.Text;
            this.Hide();
            NameEntry enterName = new NameEntry();
            enterName.Closed += (s, args) => this.Close();
            enterName.Show();
        }

        private void PlayerSelection_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Data\Nintendo-NES-Font.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
            btnBack.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            btnNext.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            btnCharacterType.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SplashScreen.sfx.controls.play();
            NextSelect();
        }

        private  void NextSelect()
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].Location.X == leftLocation[0] && characters[i].Location.Y == leftLocation[1])
                {
                    characters[i].BringToFront();
                    Size size = new Size(275, 350);
                    characters[i].Size = size;
                    characters[i].Enabled = true;
                    characters[i].Location = new Point(centerLocation[0], centerLocation[1]);
                    btnCharacterType.Text = characters[i].Tag.ToString();
                }
                else if (characters[i].Location.X == rightLocation[0] && characters[i].Location.Y == rightLocation[1])
                {
                    characters[i].Location = new Point(leftLocation[0], leftLocation[1]);
                }
                else
                {
                    Size size = new Size(175, 250);
                    characters[i].Size = size;
                    characters[i].Enabled = false;
                    characters[i].Location = new Point(rightLocation[0], rightLocation[1]);
                }
            }
        }



        private  void btnBack_Click(object sender, EventArgs e)
        {
            SplashScreen.sfx.controls.play();
            BackSelect();
        }

        private void BackSelect()
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].Location.X == leftLocation[0] && characters[i].Location.Y == leftLocation[1])
                {
                    characters[i].Location = new Point(rightLocation[0], rightLocation[1]);
                }
                else if (characters[i].Location.X == rightLocation[0] && characters[i].Location.Y == rightLocation[1])
                {
                    characters[i].BringToFront();
                    Size size = new Size(275, 350);
                    characters[i].Size = size;
                    characters[i].Enabled = true;
                    characters[i].Location = new Point(centerLocation[0], centerLocation[1]);
                    btnCharacterType.Text = characters[i].Tag.ToString();
                }
                else
                {
                    Size size = new Size(175, 250);
                    characters[i].Size = size;
                    characters[i].Enabled = false;
                    characters[i].Location = new Point(leftLocation[0], leftLocation[1]);
                }
            }
        }
    }
}
