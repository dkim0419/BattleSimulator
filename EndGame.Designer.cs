namespace BattleSimulator
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.picCharmanderLose = new System.Windows.Forms.PictureBox();
            this.picCharmanderWin = new System.Windows.Forms.PictureBox();
            this.picPikachuLose = new System.Windows.Forms.PictureBox();
            this.picPikachuWin = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCharmanderLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharmanderWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPikachuLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPikachuWin)).BeginInit();
            this.SuspendLayout();
            // 
            // picCharmanderLose
            // 
            this.picCharmanderLose.Image = ((System.Drawing.Image)(resources.GetObject("picCharmanderLose.Image")));
            this.picCharmanderLose.Location = new System.Drawing.Point(-3, -3);
            this.picCharmanderLose.Name = "picCharmanderLose";
            this.picCharmanderLose.Size = new System.Drawing.Size(192, 190);
            this.picCharmanderLose.TabIndex = 0;
            this.picCharmanderLose.TabStop = false;
            this.picCharmanderLose.Visible = false;
            // 
            // picCharmanderWin
            // 
            this.picCharmanderWin.Image = ((System.Drawing.Image)(resources.GetObject("picCharmanderWin.Image")));
            this.picCharmanderWin.Location = new System.Drawing.Point(298, 12);
            this.picCharmanderWin.Name = "picCharmanderWin";
            this.picCharmanderWin.Size = new System.Drawing.Size(270, 305);
            this.picCharmanderWin.TabIndex = 1;
            this.picCharmanderWin.TabStop = false;
            this.picCharmanderWin.Visible = false;
            // 
            // picPikachuLose
            // 
            this.picPikachuLose.Image = ((System.Drawing.Image)(resources.GetObject("picPikachuLose.Image")));
            this.picPikachuLose.Location = new System.Drawing.Point(-3, 173);
            this.picPikachuLose.Name = "picPikachuLose";
            this.picPikachuLose.Size = new System.Drawing.Size(269, 262);
            this.picPikachuLose.TabIndex = 2;
            this.picPikachuLose.TabStop = false;
            this.picPikachuLose.Visible = false;
            // 
            // picPikachuWin
            // 
            this.picPikachuWin.Image = ((System.Drawing.Image)(resources.GetObject("picPikachuWin.Image")));
            this.picPikachuWin.Location = new System.Drawing.Point(176, 19);
            this.picPikachuWin.Name = "picPikachuWin";
            this.picPikachuWin.Size = new System.Drawing.Size(379, 354);
            this.picPikachuWin.TabIndex = 3;
            this.picPikachuWin.TabStop = false;
            this.picPikachuWin.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(319, 384);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(115, 51);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "New Game";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(440, 384);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(115, 51);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(12, 442);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(543, 34);
            this.lblWinner.TabIndex = 6;
            this.lblWinner.Text = "label1";
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(567, 485);
            this.ControlBox = false;
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.picCharmanderLose);
            this.Controls.Add(this.picPikachuWin);
            this.Controls.Add(this.picPikachuLose);
            this.Controls.Add(this.picCharmanderWin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndGame";
            this.Text = "Game Over!";
            this.Load += new System.EventHandler(this.EndGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCharmanderLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharmanderWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPikachuLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPikachuWin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCharmanderLose;
        private System.Windows.Forms.PictureBox picCharmanderWin;
        private System.Windows.Forms.PictureBox picPikachuLose;
        private System.Windows.Forms.PictureBox picPikachuWin;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblWinner;
    }
}