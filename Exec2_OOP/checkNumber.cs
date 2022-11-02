using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exec2_OOP
{
	public class checkNumber
	{
		private string ans = String.Empty;
		private int i;
		public string getAnswer()
		{
			int seed = Guid.NewGuid().GetHashCode();
			Random random = new Random(seed);
			while (ans.Length < 4)
			{
				i = random.Next(0, 10);
				if (!ans.Contains(i.ToString()))
				{
					ans += i.ToString();
				}
				
			}

			return ans;
		}

		public void NewGame()
		{

		}
	}


}
