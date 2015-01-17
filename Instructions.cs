/* Daniel Kim
 * March 1, 2013
 * This program provides attack instructions to play the battle simulator game.
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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            //print out all the information about each move
            InitializeComponent();

            lstAtkDescription.Items.Add("SCRATCH: A basic move that does 10 DMG.");
            lstAtkDescription.Items.Add("");
            lstAtkDescription.Items.Add("HEAL: Heals 15 of the Pokemon's HP. Limited Usage.");
            lstAtkDescription.Items.Add("");
            lstAtkDescription.Items.Add("FLAMETHROWER: A special move that does 25 DMG.");
            lstAtkDescription.Items.Add("Requires 5MP per use.");
            lstAtkDescription.Items.Add("");
            lstAtkDescription.Items.Add("RUN: Heals 10HP, adds one heal count, and 5MP.");
            lstAtkDescription.Items.Add("Also heals 25 of your opponent's HP.");
        }
    }
}
