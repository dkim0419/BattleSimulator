namespace BattleSimulator
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.btnSpecialAtk = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnLstHistoryExpand = new System.Windows.Forms.Button();
            this.picCharmander = new System.Windows.Forms.PictureBox();
            this.picPikachu = new System.Windows.Forms.PictureBox();
            this.lblMyPokemon = new System.Windows.Forms.Label();
            this.lblMyHP = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.lblOpponentHP = new System.Windows.Forms.Label();
            this.lblMyMP = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnAtk = new System.Windows.Forms.Button();
            this.tmrHitAnimation = new System.Windows.Forms.Timer(this.components);
            this.btnNextEvent = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnForfeit = new System.Windows.Forms.Button();
            this.lblOpponentMP = new System.Windows.Forms.Label();
            this.lblOpponentHealCount = new System.Windows.Forms.Label();
            this.lblMyHealCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCharmander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPikachu)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpecialAtk
            // 
            this.btnSpecialAtk.Location = new System.Drawing.Point(11, 71);
            this.btnSpecialAtk.Name = "btnSpecialAtk";
            this.btnSpecialAtk.Size = new System.Drawing.Size(95, 46);
            this.btnSpecialAtk.TabIndex = 1;
            this.btnSpecialAtk.Text = "Flamethrower";
            this.btnSpecialAtk.UseVisualStyleBackColor = true;
            this.btnSpecialAtk.Click += new System.EventHandler(this.btnSpecialAtk_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(112, 71);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(95, 46);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(12, 331);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(514, 56);
            this.lstHistory.TabIndex = 4;
            // 
            // btnLstHistoryExpand
            // 
            this.btnLstHistoryExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLstHistoryExpand.Location = new System.Drawing.Point(532, 331);
            this.btnLstHistoryExpand.Name = "btnLstHistoryExpand";
            this.btnLstHistoryExpand.Size = new System.Drawing.Size(22, 56);
            this.btnLstHistoryExpand.TabIndex = 5;
            this.btnLstHistoryExpand.Text = "^";
            this.btnLstHistoryExpand.UseVisualStyleBackColor = true;
            this.btnLstHistoryExpand.Click += new System.EventHandler(this.btnLstHistoryExpand_Click);
            // 
            // picCharmander
            // 
            this.picCharmander.BackColor = System.Drawing.Color.Transparent;
            this.picCharmander.Image = ((System.Drawing.Image)(resources.GetObject("picCharmander.Image")));
            this.picCharmander.Location = new System.Drawing.Point(12, 152);
            this.picCharmander.Name = "picCharmander";
            this.picCharmander.Size = new System.Drawing.Size(214, 180);
            this.picCharmander.TabIndex = 6;
            this.picCharmander.TabStop = false;
            // 
            // picPikachu
            // 
            this.picPikachu.BackColor = System.Drawing.Color.Transparent;
            this.picPikachu.Image = ((System.Drawing.Image)(resources.GetObject("picPikachu.Image")));
            this.picPikachu.Location = new System.Drawing.Point(419, 9);
            this.picPikachu.Name = "picPikachu";
            this.picPikachu.Size = new System.Drawing.Size(173, 160);
            this.picPikachu.TabIndex = 7;
            this.picPikachu.TabStop = false;
            // 
            // lblMyPokemon
            // 
            this.lblMyPokemon.AutoSize = true;
            this.lblMyPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyPokemon.Location = new System.Drawing.Point(231, 187);
            this.lblMyPokemon.Name = "lblMyPokemon";
            this.lblMyPokemon.Size = new System.Drawing.Size(111, 20);
            this.lblMyPokemon.TabIndex = 8;
            this.lblMyPokemon.Text = "lblMyPokemon";
            // 
            // lblMyHP
            // 
            this.lblMyHP.AutoSize = true;
            this.lblMyHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyHP.Location = new System.Drawing.Point(232, 207);
            this.lblMyHP.Name = "lblMyHP";
            this.lblMyHP.Size = new System.Drawing.Size(54, 16);
            this.lblMyHP.TabIndex = 9;
            this.lblMyHP.Text = "HP: 150";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.Location = new System.Drawing.Point(340, 12);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(145, 20);
            this.lblOpponent.TabIndex = 10;
            this.lblOpponent.Text = "Wild Pikachu Lv. 60";
            // 
            // lblOpponentHP
            // 
            this.lblOpponentHP.AutoSize = true;
            this.lblOpponentHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentHP.Location = new System.Drawing.Point(341, 32);
            this.lblOpponentHP.Name = "lblOpponentHP";
            this.lblOpponentHP.Size = new System.Drawing.Size(54, 16);
            this.lblOpponentHP.TabIndex = 11;
            this.lblOpponentHP.Text = "HP: 150";
            // 
            // lblMyMP
            // 
            this.lblMyMP.AutoSize = true;
            this.lblMyMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyMP.Location = new System.Drawing.Point(232, 223);
            this.lblMyMP.Name = "lblMyMP";
            this.lblMyMP.Size = new System.Drawing.Size(48, 16);
            this.lblMyMP.TabIndex = 12;
            this.lblMyMP.Text = "MP: 25";
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(112, 19);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(95, 46);
            this.btnHeal.TabIndex = 2;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnAtk
            // 
            this.btnAtk.Location = new System.Drawing.Point(11, 19);
            this.btnAtk.Name = "btnAtk";
            this.btnAtk.Size = new System.Drawing.Size(95, 46);
            this.btnAtk.TabIndex = 0;
            this.btnAtk.Text = "Scratch";
            this.btnAtk.UseVisualStyleBackColor = true;
            this.btnAtk.Click += new System.EventHandler(this.btnAtk_Click);
            // 
            // tmrHitAnimation
            // 
            this.tmrHitAnimation.Tick += new System.EventHandler(this.tmrHitAnimation_Tick);
            // 
            // btnNextEvent
            // 
            this.btnNextEvent.Enabled = false;
            this.btnNextEvent.Location = new System.Drawing.Point(561, 331);
            this.btnNextEvent.Name = "btnNextEvent";
            this.btnNextEvent.Size = new System.Drawing.Size(50, 56);
            this.btnNextEvent.TabIndex = 13;
            this.btnNextEvent.Text = "OK";
            this.btnNextEvent.UseVisualStyleBackColor = true;
            this.btnNextEvent.Click += new System.EventHandler(this.btnNextEvent_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnAtk);
            this.groupBox.Controls.Add(this.btnHeal);
            this.groupBox.Controls.Add(this.btnSpecialAtk);
            this.groupBox.Controls.Add(this.btnRun);
            this.groupBox.Location = new System.Drawing.Point(395, 188);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(216, 127);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Charmander\'s Moves";
            // 
            // btnForfeit
            // 
            this.btnForfeit.Location = new System.Drawing.Point(12, 9);
            this.btnForfeit.Name = "btnForfeit";
            this.btnForfeit.Size = new System.Drawing.Size(75, 23);
            this.btnForfeit.TabIndex = 16;
            this.btnForfeit.Text = "Forfeit";
            this.btnForfeit.UseVisualStyleBackColor = true;
            this.btnForfeit.Click += new System.EventHandler(this.btnForfeit_Click);
            // 
            // lblOpponentMP
            // 
            this.lblOpponentMP.AutoSize = true;
            this.lblOpponentMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentMP.Location = new System.Drawing.Point(341, 48);
            this.lblOpponentMP.Name = "lblOpponentMP";
            this.lblOpponentMP.Size = new System.Drawing.Size(48, 16);
            this.lblOpponentMP.TabIndex = 17;
            this.lblOpponentMP.Text = "MP: 25";
            // 
            // lblOpponentHealCount
            // 
            this.lblOpponentHealCount.AutoSize = true;
            this.lblOpponentHealCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentHealCount.Location = new System.Drawing.Point(341, 64);
            this.lblOpponentHealCount.Name = "lblOpponentHealCount";
            this.lblOpponentHealCount.Size = new System.Drawing.Size(87, 16);
            this.lblOpponentHealCount.TabIndex = 18;
            this.lblOpponentHealCount.Text = "Heal Count: 3";
            // 
            // lblMyHealCount
            // 
            this.lblMyHealCount.AutoSize = true;
            this.lblMyHealCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyHealCount.Location = new System.Drawing.Point(232, 239);
            this.lblMyHealCount.Name = "lblMyHealCount";
            this.lblMyHealCount.Size = new System.Drawing.Size(87, 16);
            this.lblMyHealCount.TabIndex = 19;
            this.lblMyHealCount.Text = "Heal Count: 3";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 410);
            this.ControlBox = false;
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lblMyHealCount);
            this.Controls.Add(this.lblOpponentHealCount);
            this.Controls.Add(this.lblOpponentMP);
            this.Controls.Add(this.btnForfeit);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnNextEvent);
            this.Controls.Add(this.lblMyMP);
            this.Controls.Add(this.lblOpponentHP);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblMyHP);
            this.Controls.Add(this.lblMyPokemon);
            this.Controls.Add(this.picPikachu);
            this.Controls.Add(this.picCharmander);
            this.Controls.Add(this.btnLstHistoryExpand);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(639, 437);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(639, 437);
            this.Name = "Game";
            this.Text = "Battle Simulator";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCharmander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPikachu)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpecialAtk;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnLstHistoryExpand;
        private System.Windows.Forms.PictureBox picCharmander;
        private System.Windows.Forms.PictureBox picPikachu;
        private System.Windows.Forms.Label lblMyPokemon;
        private System.Windows.Forms.Label lblMyHP;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.Label lblOpponentHP;
        private System.Windows.Forms.Label lblMyMP;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnAtk;
        private System.Windows.Forms.Timer tmrHitAnimation;
        private System.Windows.Forms.Button btnNextEvent;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnForfeit;
        private System.Windows.Forms.Label lblOpponentMP;
        private System.Windows.Forms.Label lblOpponentHealCount;
        private System.Windows.Forms.Label lblMyHealCount;
    }
}

