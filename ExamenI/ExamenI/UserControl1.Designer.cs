namespace ExamenI
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userGuess = new System.Windows.Forms.TextBox();
            this.attemptsRemaining = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.partialResults = new System.Windows.Forms.Label();
            this.endGame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(352, 355);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 47);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attempts remaining";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your guess";
            // 
            // userGuess
            // 
            this.userGuess.Enabled = false;
            this.userGuess.Location = new System.Drawing.Point(297, 108);
            this.userGuess.Name = "userGuess";
            this.userGuess.Size = new System.Drawing.Size(263, 22);
            this.userGuess.TabIndex = 3;
            // 
            // attemptsRemaining
            // 
            this.attemptsRemaining.AutoSize = true;
            this.attemptsRemaining.Location = new System.Drawing.Point(702, 33);
            this.attemptsRemaining.Name = "attemptsRemaining";
            this.attemptsRemaining.Size = new System.Drawing.Size(0, 17);
            this.attemptsRemaining.TabIndex = 4;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(169, 183);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(94, 17);
            this.text.TabIndex = 5;
            this.text.Text = "Partial results";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(47, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 33);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // partialResults
            // 
            this.partialResults.AutoSize = true;
            this.partialResults.Location = new System.Drawing.Point(294, 183);
            this.partialResults.Name = "partialResults";
            this.partialResults.Size = new System.Drawing.Size(0, 17);
            this.partialResults.TabIndex = 7;
            // 
            // endGame
            // 
            this.endGame.AutoSize = true;
            this.endGame.Location = new System.Drawing.Point(294, 300);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(0, 17);
            this.endGame.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total results";
            // 
            // totalResults
            // 
            this.totalResults.AutoSize = true;
            this.totalResults.Location = new System.Drawing.Point(294, 222);
            this.totalResults.Name = "totalResults";
            this.totalResults.Size = new System.Drawing.Size(0, 17);
            this.totalResults.TabIndex = 10;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.totalResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.partialResults);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.text);
            this.Controls.Add(this.attemptsRemaining);
            this.Controls.Add(this.userGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userGuess;
        private System.Windows.Forms.Label attemptsRemaining;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label partialResults;
        private System.Windows.Forms.Label endGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalResults;
    }
}
