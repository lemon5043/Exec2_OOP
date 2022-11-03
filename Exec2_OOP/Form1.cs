namespace Exec2_OOP
{
	public partial class Form1 : Form
	{
		private CheckNumber checkNumber;
		public Form1()
		{
			InitializeComponent();
			checkNumber = CheckNumber.NewGame();
			lblanswer.Text = checkNumber.Answer;

		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{
			checkNumber = CheckNumber.NewGame();
			txtHint.Text = String.Empty;
			txtAnswer.Text = String.Empty;
			lblanswer.Text = checkNumber.Answer;
		}
		private void btnGo_Click(object sender, EventArgs e)
		{
			string guess = txtAnswer.Text;
			string hint = checkNumber.GuessNumber(guess);
			txtHint.Text += hint;
		}
	}
}