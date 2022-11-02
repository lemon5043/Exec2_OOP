using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Dice
	{
		private int dice1;
		private int dice2;
		private int dice3;
		private int dice4;
		private int[] playGame = new int[4];
			


	public int[] RollFourDice()
	{
		do
		{
			dice1 = RollDice();
			dice2 = RollDice();
			dice3 = RollDice();
			dice4 = RollDice();
			playGame = new int[] { dice1, dice2, dice3, dice4
			};
		} while (playGame.Length == playGame.Distinct().Count());

		return playGame;
	}

	private int RollDice()
	{
		int number;
		int seed = Guid.NewGuid().GetHashCode();
		Random random = new Random(seed);
		number = random.Next(1, 7);
		return number;
	}
	}
}
