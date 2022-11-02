using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//這題我用主控台試試看
			Dice D = new Dice();
			int[] result = D.RollFourDice();
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(counterDice(result));
		}

		static int counterDice(int[] arr)
		{
			Array.Sort(arr);
			//4個都重複
			if (arr[0] == arr[1] && arr[0] == arr[2] && arr[0] == arr[3])
			{
				return arr[0] * 2;
			} 
			//3個重複
			if (arr[0] == arr[1] && arr[0] == arr[2])
			{
				return arr[0] + arr[3];
			} 
			
			if (arr[1] == arr[2] && arr[1] == arr[3])
			{
				return arr[1] + arr[3];
			}
			//兩組各兩兩重複 ex 2233
			if (arr[0] == arr[1] && arr[2] == arr[3])
			{
				return arr[2] + arr[3];
			}
			//兩個重複
			int counter = 0;

			foreach (var item in arr)
			{
				counter += item;
			}

			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] == arr[i - 1])
				{
					counter -= arr[i] * 2;
				}
			}

			return counter;
		}
	}
}
