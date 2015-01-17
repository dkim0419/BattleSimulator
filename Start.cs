/* Daniel Kim
 * March 2, 2013
 * This program shows the start menu of the battle
 * simulator game, where they can enter their name.
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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /* send user and opponent name info to Game.cs, and open 
             * Game.cs when user clicks the start button */

            if (txtUserName.Text == "")
            {
                //cannot start the game until the user has inputted a name
                MessageBox.Show("Please input a name.");
                return;
            }

            Game Game = new Game();
            Game.userName = txtUserName.Text;
            Game.Show();
            this.Hide();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //opens up the instructions window in a new form.
            Instructions Instructions = new Instructions();
            Instructions.Show();
        }
    }
}
