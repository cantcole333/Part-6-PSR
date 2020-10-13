namespace Part_6_PSR
{
    partial class Form1
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
            this.grpPlayerChoice.SuspendLayout();
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
            this.grpPlayerChoice.Location = new System.Drawing.Point(30, 46);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(141, 115);
            this.grpPlayerChoice.TabIndex = 3;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Player Choice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPlayerChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnRock;
        private System.Windows.Forms.RadioButton radBtnPaper;
        private System.Windows.Forms.RadioButton radBtnScissors;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
    }
}

