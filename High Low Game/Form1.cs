using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_Low_Game
{
	public partial class frmHighLow : Form
	{
		int intNumGuesses = 0;
		int intBestScore = 99;
		int intRandomNumber;
		
		
		public frmHighLow()
		{
			InitializeComponent();

			btnGuess.Enabled = false;
			txtGuess.Enabled = false;
			
			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private bool isNumberInt(string strInput)
		{
			try
			{
				int intValue = int.Parse(strInput);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			
			Random rnRandomNumber = new Random();
			intRandomNumber = rnRandomNumber.Next(0, 1000);
			lblRandomNumber.Text = intRandomNumber.ToString();
			lblNumGuesses.Text = "0";
			
			btnStart.Enabled = false;
			btnGuess.Enabled = true;
			txtGuess.Enabled = true;
			txtGuess.Focus();
		}

		private void btnGuess_Click(object sender, EventArgs e)
		{
		
			intNumGuesses++;
			lblNumGuesses.Text = (intNumGuesses).ToString();

			if (!isNumberInt(txtGuess.Text))
			{
				MessageBox.Show("Integers Only.  Retry.");
				txtGuess.Focus();
			}
			else
			{
				int intGuess = int.Parse(txtGuess.Text);
				if (intGuess < intRandomNumber)
				{
					MessageBox.Show("To Low");
					txtGuess.Text = "";
					txtGuess.Focus();
				}
				else if (intGuess > intRandomNumber)
				{
					MessageBox.Show("To High");
					txtGuess.Text = "";
					txtGuess.Focus();
				}
				else if (intGuess == intRandomNumber)
				{
					MessageBox.Show("You guessed it in " +intNumGuesses.ToString()+ " attempts.");
					txtGuess.Enabled = false;
					btnGuess.Enabled = false;
					btnStart.Enabled = true;
					

					if (intNumGuesses<intBestScore)
					{
						intBestScore = intNumGuesses;
						lblBestScore.Text = (intNumGuesses.ToString());
						lblNumGuesses.Text = "0";
						intNumGuesses = 0;
						txtGuess.Text = ("");

					}
					intNumGuesses = 0;
					txtGuess.Text = ("");
				}
			}


		}
	}
}
