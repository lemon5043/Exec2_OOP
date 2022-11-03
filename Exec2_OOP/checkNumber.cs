using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exec2_OOP
{
	public class CheckNumber
	{
		public string Answer { get; }

		public static CheckNumber NewGame()
		{
			string answer = getAnswer();
			return new CheckNumber(answer);
		}

		public CheckNumber (string answer)
		{
			this.Answer = answer;
		}

		private static string getAnswer()
		{
			string i = string.Empty;
			string ans = String.Empty;
			int seed = Guid.NewGuid().GetHashCode();
			Random random = new Random(seed);
			while (ans.Length < 4)
			{
				i = random.Next(0, 10).ToString();
				if (!ans.Contains(i))
				{
					ans += i;
				}
				
			}
			return ans;
		}

		public string GuessNumber(string input)
		{
			bool isInt = int.TryParse(input, out int result);
			if (!isInt || input.Length != 4)
			{
				return "請輸入4個不重複的數字 \r\n";
			}
			int a = 0;
			int b = 0;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == Answer[i])
				{
					a++;
				}
				else if (Answer.Contains(input[i]))
				{
					b++;
				}
			}
				if (a == 4 && b == 0)
			{
				return "You win!";
			}
			return $"{a}A{b}B \r\n";
		}
	}
}
