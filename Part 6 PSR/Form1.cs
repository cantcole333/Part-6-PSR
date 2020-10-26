using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6_PSR
{
    public partial class PSR : Form
    {
        Random generator = new Random(); 
        public PSR()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radBtnPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock_Paper;
        }

        private void grpPlayerChoice_Enter(object sender, EventArgs e)
        {

        }

        private void radBtnRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock_Rock;
        }

        private void radBtnScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock_Scissors;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int compChoice = generator.Next(1,4);
            if (compChoice == 1)
            {
                imgOpponent.Image = Properties.Resources.Kevin_Rock;
            }
            else if (compChoice == 2)
            {
                imgOpponent.Image = Properties.Resources.Kevin_Paper;
            }
            else if (compChoice == 3)
            {
                imgOpponent.Image = Properties.Resources.Kevin_Scissors;
            }

        }
    }
}
