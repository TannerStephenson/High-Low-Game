namespace High_Low_Game
{
	partial class frmHighLow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighLow));
			this.btnExit = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtGuess = new System.Windows.Forms.TextBox();
			this.btnGuess = new System.Windows.Forms.Button();
			this.lblNumGuessesLabel = new System.Windows.Forms.Label();
			this.lblBestScoreLabel = new System.Windows.Forms.Label();
			this.lblNumGuesses = new System.Windows.Forms.Label();
			this.lblBestScore = new System.Windows.Forms.Label();
			this.lblHighLow = new System.Windows.Forms.Label();
			this.lblRandomNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(338, 323);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(306, 140);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(107, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "&Start Game";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtGuess
			// 
			this.txtGuess.Location = new System.Drawing.Point(100, 262);
			this.txtGuess.Name = "txtGuess";
			this.txtGuess.Size = new System.Drawing.Size(100, 22);
			this.txtGuess.TabIndex = 7;
			// 
			// btnGuess
			// 
			this.btnGuess.Location = new System.Drawing.Point(244, 250);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(75, 47);
			this.btnGuess.TabIndex = 8;
			this.btnGuess.Text = "Submit &Guess";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// lblNumGuessesLabel
			// 
			this.lblNumGuessesLabel.AutoSize = true;
			this.lblNumGuessesLabel.Location = new System.Drawing.Point(80, 146);
			this.lblNumGuessesLabel.Name = "lblNumGuessesLabel";
			this.lblNumGuessesLabel.Size = new System.Drawing.Size(138, 17);
			this.lblNumGuessesLabel.TabIndex = 2;
			this.lblNumGuessesLabel.Text = "Number of Guesses:";
			// 
			// lblBestScoreLabel
			// 
			this.lblBestScoreLabel.AutoSize = true;
			this.lblBestScoreLabel.Location = new System.Drawing.Point(80, 203);
			this.lblBestScoreLabel.Name = "lblBestScoreLabel";
			this.lblBestScoreLabel.Size = new System.Drawing.Size(120, 17);
			this.lblBestScoreLabel.TabIndex = 5;
			this.lblBestScoreLabel.Text = "Best (Low) Score:";
			// 
			// lblNumGuesses
			// 
			this.lblNumGuesses.AutoSize = true;
			this.lblNumGuesses.Location = new System.Drawing.Point(224, 146);
			this.lblNumGuesses.Name = "lblNumGuesses";
			this.lblNumGuesses.Size = new System.Drawing.Size(16, 17);
			this.lblNumGuesses.TabIndex = 3;
			this.lblNumGuesses.Text = "0";
			// 
			// lblBestScore
			// 
			this.lblBestScore.AutoSize = true;
			this.lblBestScore.Location = new System.Drawing.Point(224, 203);
			this.lblBestScore.Name = "lblBestScore";
			this.lblBestScore.Size = new System.Drawing.Size(16, 17);
			this.lblBestScore.TabIndex = 6;
			this.lblBestScore.Text = "?";
			// 
			// lblHighLow
			// 
			this.lblHighLow.AutoSize = true;
			this.lblHighLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHighLow.ForeColor = System.Drawing.Color.Red;
			this.lblHighLow.Location = new System.Drawing.Point(91, 49);
			this.lblHighLow.Name = "lblHighLow";
			this.lblHighLow.Size = new System.Drawing.Size(251, 38);
			this.lblHighLow.TabIndex = 1;
			this.lblHighLow.Text = "High/Low Game";
			// 
			// lblRandomNumber
			// 
			this.lblRandomNumber.AutoSize = true;
			this.lblRandomNumber.Location = new System.Drawing.Point(12, 9);
			this.lblRandomNumber.Name = "lblRandomNumber";
			this.lblRandomNumber.Size = new System.Drawing.Size(16, 17);
			this.lblRandomNumber.TabIndex = 0;
			this.lblRandomNumber.Text = "0";
			// 
			// frmHighLow
			// 
			this.AcceptButton = this.btnGuess;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 373);
			this.Controls.Add(this.lblRandomNumber);
			this.Controls.Add(this.lblHighLow);
			this.Controls.Add(this.lblBestScore);
			this.Controls.Add(this.lblNumGuesses);
			this.Controls.Add(this.lblBestScoreLabel);
			this.Controls.Add(this.lblNumGuessesLabel);
			this.Controls.Add(this.btnGuess);
			this.Controls.Add(this.txtGuess);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnExit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmHighLow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "High/Low Game";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtGuess;
		private System.Windows.Forms.Button btnGuess;
		private System.Windows.Forms.Label lblNumGuessesLabel;
		private System.Windows.Forms.Label lblBestScoreLabel;
		private System.Windows.Forms.Label lblNumGuesses;
		private System.Windows.Forms.Label lblBestScore;
		private System.Windows.Forms.Label lblHighLow;
		private System.Windows.Forms.Label lblRandomNumber;
	}
}

