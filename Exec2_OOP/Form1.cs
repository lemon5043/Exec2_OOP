namespace Exec2_OOP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			string guess = txtAnswer.Text;

			bool isInt = int.TryParse(guess, out int n);
			if (guess.Length != 4)
			{
				MessageBox.Show("請輸入4個不同的數字");
			}

			int a = 0;
			int b = 0;
		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{
			checkNumber cN = new checkNumber();
			txtHint.Text = String.Empty;
			txtAnswer.Text = String.Empty;
			cN.NewGame();
			lblanswer.Text = cN.Answer;
		}
	}
}