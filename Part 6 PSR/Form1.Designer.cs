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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblOpponentNum = new System.Windows.Forms.Label();
            this.lblOpponentChoice = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lstScore = new System.Windows.Forms.ListBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnRedemption = new System.Windows.Forms.Button();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // radBtnRock
            // 
            this.radBtnRock.AutoSize = true;
            this.radBtnRock.Location = new System.Drawing.Point(8, 31);
            this.radBtnRock.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnRock.Name = "radBtnRock";
            this.radBtnRock.Size = new System.Drawing.Size(77, 29);
            this.radBtnRock.TabIndex = 0;
            this.radBtnRock.TabStop = true;
            this.radBtnRock.Text = "Rock";
            this.radBtnRock.UseVisualStyleBackColor = true;
            this.radBtnRock.CheckedChanged += new System.EventHandler(this.radBtnRock_CheckedChanged);
            // 
            // radBtnPaper
            // 
            this.radBtnPaper.AutoSize = true;
            this.radBtnPaper.Location = new System.Drawing.Point(8, 68);
            this.radBtnPaper.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnPaper.Name = "radBtnPaper";
            this.radBtnPaper.Size = new System.Drawing.Size(85, 29);
            this.radBtnPaper.TabIndex = 1;
            this.radBtnPaper.TabStop = true;
            this.radBtnPaper.Text = "Paper";
            this.radBtnPaper.UseVisualStyleBackColor = true;
            this.radBtnPaper.CheckedChanged += new System.EventHandler(this.radBtnPaper_CheckedChanged);
            // 
            // radBtnScissors
            // 
            this.radBtnScissors.AutoSize = true;
            this.radBtnScissors.Location = new System.Drawing.Point(8, 105);
            this.radBtnScissors.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnScissors.Name = "radBtnScissors";
            this.radBtnScissors.Size = new System.Drawing.Size(108, 29);
            this.radBtnScissors.TabIndex = 2;
            this.radBtnScissors.TabStop = true;
            this.radBtnScissors.Text = "Scissors";
            this.radBtnScissors.UseVisualStyleBackColor = true;
            this.radBtnScissors.CheckedChanged += new System.EventHandler(this.radBtnScissors_CheckedChanged);
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radBtnRock);
            this.grpPlayerChoice.Controls.Add(this.radBtnPaper);
            this.grpPlayerChoice.Controls.Add(this.radBtnScissors);
            this.grpPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerChoice.Location = new System.Drawing.Point(24, 305);
            this.grpPlayerChoice.Margin = new System.Windows.Forms.Padding(4);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Padding = new System.Windows.Forms.Padding(4);
            this.grpPlayerChoice.Size = new System.Drawing.Size(188, 142);
            this.grpPlayerChoice.TabIndex = 3;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice";
            this.grpPlayerChoice.Enter += new System.EventHandler(this.grpPlayerChoice_Enter);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Part_6_PSR.Properties.Resources.Rock_Rock;
            this.imgPlayer.Location = new System.Drawing.Point(32, 81);
            this.imgPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(169, 217);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 4;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Part_6_PSR.Properties.Resources.Kevin_Paper;
            this.imgOpponent.Location = new System.Drawing.Point(417, 87);
            this.imgOpponent.Margin = new System.Windows.Forms.Padding(4);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(223, 210);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 5;
            this.imgOpponent.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(77, 36);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(81, 29);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.Click += new System.EventHandler(this.lblPlayer_Click);
            // 
            // lblOpp
            // 
            this.lblOpp.AutoSize = true;
            this.lblOpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpp.Location = new System.Drawing.Point(457, 36);
            this.lblOpp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpp.Name = "lblOpp";
            this.lblOpp.Size = new System.Drawing.Size(120, 29);
            this.lblOpp.TabIndex = 7;
            this.lblOpp.Text = "Opponent";
            this.lblOpp.Click += new System.EventHandler(this.lblOpp_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(252, 139);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 33);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Click to Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblOpponentNum
            // 
            this.lblOpponentNum.AutoSize = true;
            this.lblOpponentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentNum.Location = new System.Drawing.Point(457, 345);
            this.lblOpponentNum.Name = "lblOpponentNum";
            this.lblOpponentNum.Size = new System.Drawing.Size(144, 87);
            this.lblOpponentNum.TabIndex = 9;
            this.lblOpponentNum.Text = "Rock = 1\r\nPaper = 2\r\nScissors = 3";
            this.lblOpponentNum.Click += new System.EventHandler(this.lblOpponentNum_Click);
            // 
            // lblOpponentChoice
            // 
            this.lblOpponentChoice.AutoSize = true;
            this.lblOpponentChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentChoice.Location = new System.Drawing.Point(427, 316);
            this.lblOpponentChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpponentChoice.Name = "lblOpponentChoice";
            this.lblOpponentChoice.Size = new System.Drawing.Size(202, 29);
            this.lblOpponentChoice.TabIndex = 10;
            this.lblOpponentChoice.Text = "Opponent Choice";
            this.lblOpponentChoice.Click += new System.EventHandler(this.lblOpponentChoice_Click);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(128, 491);
            this.lblGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(0, 29);
            this.lblGame.TabIndex = 11;
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGame.Click += new System.EventHandler(this.lblGame_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(252, 178);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(100, 30);
            this.btnPlayAgain.TabIndex = 12;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(237, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 123);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(61, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 47);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(440, 27);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 47);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(417, 302);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(230, 52);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(449, 344);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(161, 95);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(101, 479);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(460, 55);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // lstScore
            // 
            this.lstScore.FormattingEnabled = true;
            this.lstScore.ItemHeight = 16;
            this.lstScore.Location = new System.Drawing.Point(252, 262);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(120, 164);
            this.lstScore.TabIndex = 19;
            this.lstScore.SelectedIndexChanged += new System.EventHandler(this.lstScore_SelectedIndexChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(237, 249);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(150, 189);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // btnRedemption
            // 
            this.btnRedemption.Location = new System.Drawing.Point(252, 105);
            this.btnRedemption.Name = "btnRedemption";
            this.btnRedemption.Size = new System.Drawing.Size(100, 29);
            this.btnRedemption.TabIndex = 21;
            this.btnRedemption.Text = "Redemption";
            this.btnRedemption.UseVisualStyleBackColor = true;
            this.btnRedemption.Click += new System.EventHandler(this.btnRedemption_Click);
            // 
            // PSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 567);
            this.Controls.Add(this.btnRedemption);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.grpPlayerChoice);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblOpponentChoice);
            this.Controls.Add(this.lblOpponentNum);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblOpp);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PSR";
            this.Text = "Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblOpponentNum;
        private System.Windows.Forms.Label lblOpponentChoice;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ListBox lstScore;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnRedemption;
    }
}

