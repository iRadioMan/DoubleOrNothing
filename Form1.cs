using System;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace DoubleOrNothing
{
    public partial class Form1 : Form
    {
        DONGame game;
        SoundPlayer winSound, loseSound, doubleSound, jackpotSound;
        public Form1(string[] args)
        {
            InitializeComponent();

            game = new DONGame(6000, 150, 200000, 50);

            winSound = new SoundPlayer(DoubleOrNothing.Properties.Resources.win);
            loseSound = new SoundPlayer(DoubleOrNothing.Properties.Resources.lose);
            doubleSound = new SoundPlayer(DoubleOrNothing.Properties.Resources.x1);
            jackpotSound = new SoundPlayer(DoubleOrNothing.Properties.Resources.jackpot);
            UpdateGame();
        }

        private void UpdateGame()
        {
            moneyLbl.Text = game.Money.ToString();
            jackpotLbl.Text = "Jackpot: " + game.Jackpot.ToString();
            multiplierLbl.Text = game.MultiplierText;
            amountLbl.Text = "Amount: " + game.Amount.ToString();
            chanceBar.Value = game.Chance;
            chanceBox.Text = "Chance: " + game.Chance.ToString() + "%";

            switch (game.Multiplier)
            {
                case 1:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x1;
                    break;
                case 2:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x2;
                    break;
                case 3:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x3;
                    break;
                case 4:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x4;
                    break;
                case 5:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x5;
                    break;
                case 6:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x6;
                    break;
                case 7:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x7;
                    break;
                case 8:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x8;
                    break;
                case 9:
                    doubleSound.Stream = DoubleOrNothing.Properties.Resources.x9;
                    break;
            }

            jackpotAnim.Visible = false;

            if (game.WinFlag == 2)
            {
                takeOutBtn.Enabled = false;
                doubleBtn.Enabled = false;
                resetBtn.Enabled = true;
                panel1.BackColor = Color.Green;
                jackpotAnim.Visible = true;
                jackpotSound.Play();
            }
            else if (game.WinFlag == 1)
            {
                takeOutBtn.Enabled = false;
                doubleBtn.Enabled = false;
                resetBtn.Enabled = true;
                panel1.BackColor = Color.Green;
                winSound.Play();
            }
            else if (game.WinFlag == -1)
            {
                takeOutBtn.Enabled = false;
                doubleBtn.Enabled = true;
                resetBtn.Enabled = false;
                panel1.BackColor = Color.Red;
                loseSound.Play();
            }
            else
            {
                takeOutBtn.Enabled = true;
                doubleBtn.Enabled = true;
                resetBtn.Enabled = false;
                panel1.BackColor = Color.Yellow;
                doubleSound.Play();
            }
        }

        private void chanceBar_Scroll(object sender, EventArgs e)
        {
            game.Chance = chanceBar.Value;
            chanceBox.Text = "Chance: " + game.Chance.ToString() + "%";
        }

        private void doubleBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                chanceBox.Visible = true;
                this.Text = "YOU CHEATER!";
            }
        }

        private void doubleBtn_Click(object sender, EventArgs e)
        {
            game.ChooseDouble();
            UpdateGame();
        }

        private void takeOutBtn_Click(object sender, EventArgs e)
        {
            game.TakeOut();
            UpdateGame();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            game.Reset();
            UpdateGame();
        }
    }
}
