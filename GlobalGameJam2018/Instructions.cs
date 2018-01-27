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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Data\Nintendo-NES-Font.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            }
            btnReturn.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }
    }
}
