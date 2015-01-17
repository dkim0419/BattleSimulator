/* Daniel Kim
 * Feb. 28, 2013
 * This program simulates a pokemon battle, where the
 * user and opponent(cpu) battle using different moves
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
    public partial class Game : Form
    {
        //stores the name of the user's pokemon from Start.cs
        public string userName;
        //if true, then the user has clicked the expand button to expand the history listbox
        bool historyExpand = true;
        //stores remaining hit points of user's pokemon
        int myHP = 150;
        //stores remaining hit points of wild pokemon
        int opponentHP = 150;
        //stores remaining heals user's pokemon has left
        int myHealCount = 3;
        //stores remaining heals opponent's pokemon has left
        int opponentHealCount = 3;
        //stores remaing magic points user's pokemon has left
        int myMP = 25;
        //stores remaining magic points of opponent's pokemon
        int opponentMP = 25;
        /* used to flash pokemon's image when hit with an attack.
         * (if true, then pic will flash off, and vice versa */
        bool picVisible = true;
        /* used to see who's attacking currently to know which 
         * pokemon to show flashing animation on. */
        bool charmanderAtk;
        //used to count num. of flashing animations shown after pokemon is hit.
        int animationCounter = 0;
        //sees how many times extra mp is awarded (can only be once)
        int extraMPCollection = 0;

        public Game()
        {
            //initialize game, add introductory lines to the listbox
            InitializeComponent();
            lstHistory.Items.Add("Welcome to the Battle Simulator!");
            lstHistory.Items.Add("Look, a wild Pikachu! Charmander, I choose you!");
            lstHistory.Items.Add("");
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //displays user's name as the pokemon name
            lblMyPokemon.Text = userName;
        }

        private void btnLstHistoryExpand_Click(object sender, EventArgs e)
        {
            // when user clicks the expand button, the listbox will expand to show game history

            if (historyExpand == true)
            {
                //expands the listbox
                lstHistory.Top = 94;
                lstHistory.Height = 290;

                btnLstHistoryExpand.Text = "v";

                historyExpand = false;
            }

            else
            {
                //minimizes the listbox
                lstHistory.Top = 331;
                lstHistory.Height = 56;

                btnLstHistoryExpand.Text = "^";

                historyExpand = true;
            }
        }

        void AliveCheck()
        {
            //checks if any of the battlers' HP has reached 0, declaring a winner.
            
            if (myHP <= 0)
            {
                //Pikachu wins the battle 

                if (MessageBox.Show("Charmander Fainted! Pikachu has won the battle!") == DialogResult.OK)
                {
                    //Shows message box declaring winner, and opens the EndGame form.
                    EndGame EndGame = new EndGame();
                    EndGame.winnerName = "Wild Pikachu";
                    EndGame.Show();
                    this.Hide();
                }
            }

            else if (opponentHP <= 0)
            {
                //Charmander wins the battle 
                
                if (MessageBox.Show("Pikachu Fainted! Charmander has won the battle!") == DialogResult.OK)
                {
                    //Shows message box declaring winner, and opens the EndGame form.
                    EndGame EndGame = new EndGame();
                    EndGame.winnerName = userName;
                    EndGame.Show();
                    this.Hide();
                }
            }
        }

        void ComputerAttack()
        {
            /* Pikachu's attack moves (starts after Charmander's moves)
            More probable to use certain moves based on the HP of user and of itself */
            
            charmanderAtk = false;

            if (myHP > 300 && extraMPCollection == 0)
            {
                /* Most likely case is that pikachu has used too many runs, 
                 * meaning the game has been dragging on for a long time when pikachu is
                 * very low health. Gives 5MP to the user to help in ending the game. */

                myMP += 5;
                lstHistory.Items.Add("Charmander found a secret item! 5MP found inside");
                lstHistory.SelectedIndex = lstHistory.Items.Count - 1;
                lstHistory.Items.Add("");

                lblMyMP.Text = "MP: " + myMP;

                extraMPCollection++;
            }

            if (opponentHP < 40)
            {
                //CPU uses Heal, Special Attack, or Run when the its hp is low.

                Random numberGenerator = new Random();
                int randomMove = numberGenerator.Next(0, 10);

                if (randomMove <= 3 && opponentHealCount > 0)
                {
                    //HEAL MOVE: Heals 15 of Pikachu's HP - 40% chance

                    lstHistory.Items.Add("Pikachu Healed and gained 15 HP");
                    opponentHealCount--;
                    opponentHP += 15;
                }

                else if (randomMove == 4 && opponentMP >= 5)
                {
                    //SP ATK: deals 25 hp damage to user - 10% chance
                    opponentMP -= 5;

                    lstHistory.Items.Add("Pikachu used its Special Attack, Thunder!");
                    lstHistory.Items.Add("Super Damage! Charmander lost 25 HP.");

                    myHP -= 25;

                    if (myHP < 0)
                    {
                        //cannot have negative hp
                        myHP = 0;
                    }
                }

                else if (randomMove <= 6)
                {
                    //BASIC ATK: does 10 damage to user - 20% chance
                    lstHistory.Items.Add("Pikachu used its basic attack, Iron Tail!");
                    lstHistory.Items.Add("Charmander is hurt! Charmander lost 10 HP");

                    myHP -= 10;

                    if (myHP < 0)
                    {
                        //cannot have negative hp
                        myHP = 0;
                    }
                }

                else
                {
                    //RUN MOVE: heals 10 of opponent's hit points - 30% chance
                    lstHistory.Items.Add("Pikachu Ran and gained 10 HP!");
                    lstHistory.Items.Add(userName + " regained 25 HP.");

                    myHP += 25;
                    opponentHP += 10;
                    opponentMP += 5;
                    opponentHealCount++;
                }
            }

            else if (myHP < 40)
            {
                //more likely to use powerful moves if Charmander is low on health

                Random numberGenerator = new Random();
                int randomMove = numberGenerator.Next(0, 5);

                if (randomMove <= 2 && opponentMP >= 5)
                {
                    //SP ATK: deals 25 hp damage to user - 60% chance

                    lstHistory.Items.Add("Pikachu used its Special Attack, Thunder!");
                    lstHistory.Items.Add("Super Damage! Charmander lost 25 HP.");

                    myHP -= 25;
                    opponentMP -= 5;

                    if (myHP < 0)
                    {
                        //can't have negative HP
                        myHP = 0;
                    }
                }
            

                else if (randomMove == 3 && opponentHealCount > 0)
                {
                    //HEAL MOVE: Heals 15 of Pikachu's HP - 20% chance

                    lstHistory.Items.Add("Pikachu Healed and gained 15 HP");
                    opponentHealCount--;
                    opponentHP += 15;
                }

                else
                {
                    //BASIC ATK: does 10 damage to user - 20% chance
                    lstHistory.Items.Add("Pikachu used its basic attack, Iron Tail!");
                    lstHistory.Items.Add("Charmander is hurt! Charmander lost 10 HP");

                    myHP -= 10;

                    if (myHP < 0)
                    {
                        //cannot have negative hp
                        myHP = 0;
                    }
                }

            }
        
            
            else
            {
                /* both pokemon both have a large amount of HP -- more likely to attack.
                 * NO RUN, due to it recovering a lot of HP for the user's pokemon */

                Random numberGenerator = new Random();
                int randomMove = numberGenerator.Next(0, 5);

                if (randomMove == 0 && opponentHealCount > 0)
                {
                    //HEAL: Heals 15 of opponent's HP - 20% chance

                    lstHistory.Items.Add("Pikachu Healed and gained 15 HP");
                    opponentHealCount--;
                    opponentHP += 15;
                }

                else if (randomMove <= 3 && opponentMP >= 5)
                {
                    //SP ATK: deals 25 hp damage to user - 60% chance

                    lstHistory.Items.Add("Pikachu used its Special Attack, Thunder!");
                    lstHistory.Items.Add("Super Damage! Charmander lost 25 HP.");

                    myHP -= 25;
                    opponentMP -= 5;

                    if (myHP < 0)
                    {
                        myHP = 0;
                    }
                }

                else
                {
                    //BASIC ATK: does 10 damage to user - 20% chance
                    lstHistory.Items.Add("Pikachu used its basic attack, Iron Tail!");
                    lstHistory.Items.Add("Charmander is hurt! Charmander lost 10 HP");

                    myHP -= 10;

                    if (myHP < 0)
                    {
                        //can't have negative HP
                        myHP = 0;
                    }
                }
            }

            lblOpponentHP.Text = "HP: " + opponentHP;
            lblMyHP.Text = "HP: " + myHP;
            lblOpponentMP.Text = "MP: " + opponentMP;
            lblOpponentHealCount.Text = "Heal Count: " + opponentHealCount;

            lstHistory.SelectedIndex = lstHistory.Items.Count - 1;
            lstHistory.Items.Add("");

            tmrHitAnimation.Enabled = true;
            AliveCheck();
        }
        
        private void btnAtk_Click(object sender, EventArgs e)
        {
            //Charmander's basic attack, Scratch. Deals 10 damage to opponent.
            charmanderAtk = true;
            lstHistory.Items.Add("Charmander used its basic attack, Scratch!");
            lstHistory.Items.Add("Pikachu is hurt! Pikachu lost 10 HP");
            lstHistory.Items.Add("Press OK to continue...");
            lstHistory.SelectedIndex = lstHistory.Items.Count - 1;
            lstHistory.Items.Add("");

            opponentHP -= 10;

            if (opponentHP < 0)
            {
                //if HP is negative, goes to 0.
                opponentHP = 0;
            }

            lblOpponentHP.Text = "HP: " + opponentHP;

            tmrHitAnimation.Enabled = true;
            groupBox.Enabled = false;
            AliveCheck();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            //Heals 15 of user's HP, can only be used 3 times (unless user chooses to 'Run' to add more heal count)

            if (myHealCount < 1)
            {
                //cannot use Heal if they do not have enough heal count.
                lstHistory.Items.Add("Out of Heals. Please select a different move");
                lstHistory.SelectedIndex = lstHistory.Items.Count - 1;
                lstHistory.Items.Add("");
                return;
            }

            charmanderAtk = true;
            lstHistory.Items.Add("Charmander Healed and gained 15 HP");
            lstHistory.Items.Add("Press OK to continue...");
            lstHistory.SelectedIndex = lstHistory.Items.Count - 1;
            lstHistory.Items.Add("");

            myHP += 15;
            myHealCount -= 1;

            lblMyHP.Text = "HP: " + myHP;
            lblMyHealCount.Text = "Heal Count: " + myHealCount;

            tmrHitAnimation.Enabled = true;
            groupBox.Enabled = false;
            AliveCheck();
        }

        private void btnSpecialAtk_Click(object sender, EventArgs e)
        {
            //deals 25 hp damage to opponent, requires 5 magic points to use.

            charmanderAtk = true;
            if (myMP < 5)
            {
                //cannot use the special attack if there is insufficient MP (req. 5)
                lstHistory.Items.Add("Not enough MP. Please select a different move");
                lstHistory.SelectedIndex = lstHistory.Items.Count - 1;
                lstHistory.Items.Add("");
                return;
            }

            lstHistory.Items.Add("Charmander used its Special Attack, Flamethrower!");
            lstHistory.Items.Add("Extreme Damage! Pikachu lost 25 HP.");
            lstHistory.Items.Add("The attack cost Charmander 5MP.");
            lstHistory.Items.Add("Press OK to continue...");
            lstHistory.SelectedIndex = lstHistory.Items.Count - 1;
            lstHistory.Items.Add("");

            opponentHP -= 25;
            myMP -= 5;

            if (opponentHP < 0)
            {
                //cannot have negative HP, goes back to 0.
                opponentHP = 0;
            }

            lblOpponentHP.Text = "HP: " + opponentHP;
            lblMyMP.Text = "MP: " + myMP;

            tmrHitAnimation.Enabled = true;
            groupBox.Enabled = false;
            AliveCheck();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            /* Heals 10 of user's hit points, adds 1 heal count, and adds 5 more MP for the user.
             * Also adds 25 HP for the opponent */

            charmanderAtk = true;
            lstHistory.Items.Add("Charmander Ran and gained 10 HP!");
            lstHistory.Items.Add("Charmander regained 1 Heal and 5MP.");
            lstHistory.Items.Add("Pikachu regained 25 HP.");
            lstHistory.Items.Add("Press OK to continue...");
            lstHistory.SelectedIndex = lstHistory.Items.Count - 1;
            lstHistory.Items.Add("");

            opponentHP += 25;
            myHP += 10;
            myHealCount++;
            myMP += 5;

            lblOpponentHP.Text = "HP: " + opponentHP;
            lblMyHP.Text = "HP: " + myHP;
            lblMyMP.Text = "MP: " + myMP;
            lblMyHealCount.Text = "Heal Count: " + myHealCount;

            tmrHitAnimation.Enabled = true;
            groupBox.Enabled = false;
            AliveCheck();
        }

        private void tmrHitAnimation_Tick(object sender, EventArgs e)
        {
            //blinks the image of the pokemon that has been attacked

            if (picVisible == true)
            {
                /* If the pictureBox is currently visible to the user, 
                 * then the image will flash off */

                if (charmanderAtk == true)
                {
                    //pikachu flashes off when charmander is attacking
                    picPikachu.Visible = false;
                }

                else
                {
                    //charmander flashes off when pikachu is attacking
                    picCharmander.Visible = false;
                }

                picVisible = false;
            }

            else
            {
                /* flashes picture box back on if it is not
                 * visible to the user */

                if (charmanderAtk == true)
                {
                    //pikachu flashes on when charmander is attacking
                    picPikachu.Visible = true;
                }

                else
                {
                    //charmander flashes on when pikachu is attacking
                    picCharmander.Visible = true;
                }

                picVisible = true;
            }

            animationCounter++;

            if (animationCounter == 4)
            {
                /* animation should only flash 2 times.
                 * ends when the counter gets to 4 */
                tmrHitAnimation.Enabled = false;
                animationCounter = 0;

                if (charmanderAtk == false)
                {
                    /* if it was pikachu that was just attacking, then
                     * the groupbox grouping all the attacks together will 
                     * become enabled again so the user can choose an attack */
                    groupBox.Enabled = true;
                    btnNextEvent.Enabled = false;
                }

                else
                {
                    // if charmander is attacking, then enable the OK button.
                    btnNextEvent.Enabled = true;
                }
            }
        }

        private void btnNextEvent_Click(object sender, EventArgs e)
        {
            /* acts as an 'A' button on a gameboy to confirm that the user
             * has read the information on the history listbox. Also starts computer attack. */

            ComputerAttack();
            btnNextEvent.Enabled = false;
        }

        private void btnForfeit_Click(object sender, EventArgs e)
        {
            //restarts the application (goes back to start screen)
            Application.Restart();
        }
    }
}
