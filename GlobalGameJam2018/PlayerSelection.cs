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

        public PlayerSelection()
        {
            InitializeComponent();
            MessageBox.Show("1 player Game");            
        }

        public PlayerSelection(bool  twoPlayerGame)
        {
            InitializeComponent();
            MessageBox.Show("2 player Game");
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
            btnCharacterType.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                wizard_x = pbxWizard.Location.X;
                wizard_y = pbxWizard.Location.Y;
                timer1.Start();
                i = 0;
            }
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbxWizard.Location = new Point(wizard_x + i, wizard_y);
            i++;
            if (pbxWizard.Location.X >= wizard_x + 50 )
            {
                timer1.Stop();
                pbxWizard.BringToFront();
            }
        }
    }
}
