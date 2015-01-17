namespace BattleSimulator
{
    partial class Instructions
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstAtkDescription = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Battle Simulator Moves";
            // 
            // lstAtkDescription
            // 
            this.lstAtkDescription.BackColor = System.Drawing.SystemColors.Menu;
            this.lstAtkDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAtkDescription.FormattingEnabled = true;
            this.lstAtkDescription.Location = new System.Drawing.Point(12, 43);
            this.lstAtkDescription.Name = "lstAtkDescription";
            this.lstAtkDescription.Size = new System.Drawing.Size(382, 169);
            this.lstAtkDescription.TabIndex = 1;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 238);
            this.Controls.Add(this.lstAtkDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstAtkDescription;

    }
}