namespace Part_6_PSR
{
    partial class PSR
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
            this.radBtnRock = new System.Windows.Forms.RadioButton();
            this.radBtnPaper = new System.Windows.Forms.RadioButton();
            this.radBtnScissors = new System.Windows.Forms.RadioButton();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblOpp = new System.Windows.Forms.Label();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // radBtnRock
            // 
            this.radBtnRock.AutoSize = true;
            this.radBtnRock.Location = new System.Drawing.Point(6, 25);
            this.radBtnRock.Name = "radBtnRock";
            this.radBtnRock.Size = new System.Drawing.Size(64, 24);
            this.radBtnRock.TabIndex = 0;
            this.radBtnRock.TabStop = true;
            this.radBtnRock.Text = "Rock";
            this.radBtnRock.UseVisualStyleBackColor = true;
            // 
            // radBtnPaper
            // 
            this.radBtnPaper.AutoSize = true;
            this.radBtnPaper.Location = new System.Drawing.Point(6, 55);
            this.radBtnPaper.Name = "radBtnPaper";
            this.radBtnPaper.Size = new System.Drawing.Size(69, 24);
            this.radBtnPaper.TabIndex = 1;
            this.radBtnPaper.TabStop = true;
            this.radBtnPaper.Text = "Paper";
            this.radBtnPaper.UseVisualStyleBackColor = true;
            this.radBtnPaper.CheckedChanged += new System.EventHandler(this.radBtnPaper_CheckedChanged);
            // 
            // radBtnScissors
            // 
            this.radBtnScissors.AutoSize = true;
            this.radBtnScissors.Location = new System.Drawing.Point(6, 85);
            this.radBtnScissors.Name = "radBtnScissors";
            this.radBtnScissors.Size = new System.Drawing.Size(87, 24);
            this.radBtnScissors.TabIndex = 2;
            this.radBtnScissors.TabStop = true;
            this.radBtnScissors.Text = "Scissors";
            this.radBtnScissors.UseVisualStyleBackColor = true;
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radBtnRock);
            this.grpPlayerChoice.Controls.Add(this.radBtnPaper);
            this.grpPlayerChoice.Controls.Add(this.radBtnScissors);
            this.grpPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerChoice.Location = new System.Drawing.Point(80, 158);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(141, 115);
            this.grpPlayerChoice.TabIndex = 3;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice";
            this.grpPlayerChoice.Enter += new System.EventHandler(this.grpPlayerChoice_Enter);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Part_6_PSR.Properties.Resources.Rock_Rock;
            this.imgPlayer.Location = new System.Drawing.Point(242, 36);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(127, 104);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 4;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Part_6_PSR.Properties.Resources.Kevin_Paper;
            this.imgOpponent.Location = new System.Drawing.Point(397, 312);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(127, 99);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 5;
            this.imgOpponent.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(279, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(62, 24);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player";
            // 
            // lblOpp
            // 
            this.lblOpp.AutoSize = true;
            this.lblOpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpp.Location = new System.Drawing.Point(409, 417);
            this.lblOpp.Name = "lblOpp";
            this.lblOpp.Size = new System.Drawing.Size(95, 24);
            this.lblOpp.TabIndex = 7;
            this.lblOpp.Text = "Opponent";
            // 
            // PSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOpp);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.grpPlayerChoice);
            this.Name = "PSR";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnRock;
        private System.Windows.Forms.RadioButton radBtnPaper;
        private System.Windows.Forms.RadioButton radBtnScissors;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblOpp;
    }
}

