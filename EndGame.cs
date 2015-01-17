/* Daniel Kim
 * March 1, 2013
 * End Game form for Battle Simulator asking to restart the game or quit.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleSimulator
{
    public partial class EndGame : Form
    {
        //stores winner's name from form 1 (Game.cs) if pikachu
        public string winnerName;

        public EndGame()
        {
            InitializeComponent();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            if (winnerName == "Wild Pikachu")
            {
                //if pikachu won the battle, then shows the appropriate images
                picCharmanderLose.Visible = true;
                picPikachuWin.Visible = true;

                lblWinner.Text = "YOU LOST...";
            }

            else
            {
                //if pikachu doesn't win (implies charmander won), show appropriate images
                picCharmanderWin.Visible = true;
                picPikachuLose.Visible = true;

                lblWinner.Text = "CONGRATULATIONS " + winnerName + "! YOU WON!";
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //restarts the application
            Application.Restart();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //exits the application
            Application.Exit();
        }
    }
}
