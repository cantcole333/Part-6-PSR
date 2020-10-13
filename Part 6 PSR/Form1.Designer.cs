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
            this.SuspendLayout();
            // 
            // radBtnRock
            // 
            this.radBtnRock.AutoSize = true;
            this.radBtnRock.Location = new System.Drawing.Point(58, 63);
            this.radBtnRock.Name = "radBtnRock";
            this.radBtnRock.Size = new System.Drawing.Size(51, 17);
            this.radBtnRock.TabIndex = 0;
            this.radBtnRock.TabStop = true;
            this.radBtnRock.Text = "Rock";
            this.radBtnRock.UseVisualStyleBackColor = true;
            // 
            // radBtnPaper
            // 
            this.radBtnPaper.AutoSize = true;
            this.radBtnPaper.Location = new System.Drawing.Point(58, 87);
            this.radBtnPaper.Name = "radBtnPaper";
            this.radBtnPaper.Size = new System.Drawing.Size(53, 17);
            this.radBtnPaper.TabIndex = 1;
            this.radBtnPaper.TabStop = true;
            this.radBtnPaper.Text = "Paper";
            this.radBtnPaper.UseVisualStyleBackColor = true;
            // 
            // radBtnScissors
            // 
            this.radBtnScissors.AutoSize = true;
            this.radBtnScissors.Location = new System.Drawing.Point(58, 111);
            this.radBtnScissors.Name = "radBtnScissors";
            this.radBtnScissors.Size = new System.Drawing.Size(64, 17);
            this.radBtnScissors.TabIndex = 2;
            this.radBtnScissors.TabStop = true;
            this.radBtnScissors.Text = "Scissors";
            this.radBtnScissors.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radBtnScissors);
            this.Controls.Add(this.radBtnPaper);
            this.Controls.Add(this.radBtnRock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnRock;
        private System.Windows.Forms.RadioButton radBtnPaper;
        private System.Windows.Forms.RadioButton radBtnScissors;
    }
}

