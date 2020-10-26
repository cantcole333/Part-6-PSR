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
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // radBtnRock
            // 
            this.radBtnRock.AutoSize = true;
            this.radBtnRock.Location = new System.Drawing.Point(8, 31);
            this.radBtnRock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.radBtnPaper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.radBtnScissors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.grpPlayerChoice.Location = new System.Drawing.Point(107, 194);
            this.grpPlayerChoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPlayerChoice.Size = new System.Drawing.Size(188, 142);
            this.grpPlayerChoice.TabIndex = 3;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice";
            this.grpPlayerChoice.Enter += new System.EventHandler(this.grpPlayerChoice_Enter);
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Part_6_PSR.Properties.Resources.Rock_Rock;
            this.imgPlayer.Location = new System.Drawing.Point(323, 44);
            this.imgPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(169, 128);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 4;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Part_6_PSR.Properties.Resources.Kevin_Paper;
            this.imgOpponent.Location = new System.Drawing.Point(529, 384);
            this.imgOpponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(169, 122);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 5;
            this.imgOpponent.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(372, 11);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(81, 29);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "Player";
            // 
            // lblOpp
            // 
            this.lblOpp.AutoSize = true;
            this.lblOpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpp.Location = new System.Drawing.Point(545, 513);
            this.lblOpp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpp.Name = "lblOpp";
            this.lblOpp.Size = new System.Drawing.Size(120, 29);
            this.lblOpp.TabIndex = 7;
            this.lblOpp.Text = "Opponent";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(506, 225);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(104, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Click to Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblOpponentNum
            // 
            this.lblOpponentNum.AutoSize = true;
            this.lblOpponentNum.Location = new System.Drawing.Point(526, 135);
            this.lblOpponentNum.Name = "lblOpponentNum";
            this.lblOpponentNum.Size = new System.Drawing.Size(85, 51);
            this.lblOpponentNum.TabIndex = 9;
            this.lblOpponentNum.Text = "Rock = 1\r\nPaper = 2\r\nScissors = 3";
            // 
            // PSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblOpponentNum);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblOpp);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.grpPlayerChoice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblOpponentNum;
    }
}

