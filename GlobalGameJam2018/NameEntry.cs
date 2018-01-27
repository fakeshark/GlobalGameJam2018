using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalGameJam2018
{
    public partial class NameEntry : Form
    {
        public NameEntry()
        {
            InitializeComponent();
        }
        string playerName = string.Empty;

        private void btnLetter_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            playerName += clickedButton.Tag.ToString();
            RefreshName();
        }

        private void RefreshName()
        {
            if (playerName.Length <= 13)
            {
                lblPlayerName.Text = playerName.Trim();
            }
            else
            {
                playerName = playerName.Substring(0, 13);
                lblPlayerName.Text = playerName.Trim();
            }
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string command = clickedButton.Tag.ToString();
            switch (command)
            {
                case "SPACE":
                    playerName += " ";
                    RefreshName();
                    break;

                case "BACKSPACE":
                    if (playerName.Length > 0)
                    {
                        playerName = playerName.Remove(playerName.Length - 1);
                    }
                    RefreshName();
                    break;

                case "CLEAR":
                    playerName = string.Empty;
                    RefreshName();
                    break;

                case "SAVE":
                    MessageBox.Show("Your name will be saved as: " + playerName);
                    break;
            }

        }
    }
}
