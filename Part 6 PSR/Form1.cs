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
        int playerChoice;
        int PlayAgain = 1;
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
            playerChoice = 2;
        }

        private void grpPlayerChoice_Enter(object sender, EventArgs e)
        {

        }

        private void radBtnRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock_Rock;
            playerChoice = 1;
        }

        private void radBtnScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock_Scissors;
            playerChoice = 3;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (PlayAgain == 0)
            {
                lblGame.Text = "Please press Play Again";
            }
            else if (PlayAgain == 1)
                {
                int compChoice = generator.Next(1,4);
                    if (compChoice == playerChoice)
                    {
                        lblGame.Text = "Tie Game!";
                        PlayAgain = 0;
                    }
                    else if (compChoice == 1 && playerChoice == 2)
                    {
                        imgOpponent.Image = Properties.Resources.Kevin_Rock;
                        lblOpponentChoice.Text = "Rock";
                        lblGame.Text = "Player won! Paper beats Rock";
                        PlayAgain = 0;
                    }
                    else if (compChoice == 2 && playerChoice == 1)
                    {
                        imgOpponent.Image = Properties.Resources.Kevin_Paper;
                        lblOpponentChoice.Text = "Paper";
                        lblGame.Text = "Computer won! Paper beats Rock";
                        PlayAgain = 0;
                     }   
                    else if (compChoice == 3 && playerChoice == 1)
                    {
                        imgOpponent.Image = Properties.Resources.Kevin_Scissors;
                        lblOpponentChoice.Text = "Scissors";
                        lblGame.Text = "Player won! Rock beats Scissors";
                        PlayAgain = 0;
                    }
                    else if (compChoice == 1 && playerChoice == 3)
                    {
                        imgOpponent.Image = Properties.Resources.Kevin_Scissors;
                        lblOpponentChoice.Text = "Scissors";
                        lblGame.Text = "Computer won! Rock beats Scissors";
                        PlayAgain = 0;
                    }
                    else if (compChoice == 2 && playerChoice == 3)
                    {
                        imgOpponent.Image = Properties.Resources.Kevin_Scissors;
                        lblOpponentChoice.Text = "Paper";
                        lblGame.Text = "Player won! Scissors beats Paper";
                        PlayAgain = 0;
                    }
                    else if (compChoice == 3 && playerChoice == 2)
                    {
                        imgOpponent.Image = Properties.Resources.Kevin_Scissors;
                        lblOpponentChoice.Text = "Scissors";
                        lblGame.Text = "Computer won! Scissors beats Paper";
                        PlayAgain = 0;
                    }

            }
            
        }

        private void lblOpponentChoice_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }

        private void lblOpp_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgain = 1;
            lblGame.Text = "";
        }

        private void lblOpponentNum_Click(object sender, EventArgs e)
        {

        }

        private void lblGame_Click(object sender, EventArgs e)
        {

        }
    }
}
