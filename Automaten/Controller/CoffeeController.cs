using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Controller
{
	internal class CoffeeController
	{
		Model.Drink drinkClass = new Model.Drink();
		internal string PickCoffee(ConsoleKeyInfo Key)
		{
			List<string> coffee = drinkClass.WhichCoffee();
			string item = null;

			switch (Key.Key)
			{
				case ConsoleKey.D1:
					{
						item = coffee[0];
						break;
					}
				case ConsoleKey.D2:
					{
						item = coffee[1];
						break;
					}
				case ConsoleKey.D3:
					{
						item = coffee[2];
						break;
					}
				case ConsoleKey.D4:
					{
						item = coffee[3];
						break;
					}
				case ConsoleKey.D5:
					{
						item = coffee[4];
						break;
					}
				case ConsoleKey.D6:
					{
						item = coffee[5];
						break;
					}
				case ConsoleKey.D7:
					{
						item = coffee[6];
						break;
					}
				case ConsoleKey.D8:
					{
						item = coffee[7];
						break;
					}
				case ConsoleKey.D9:
					{
						item = coffee[8];
						break;
					}
				case ConsoleKey.D0:
					{
						item = " ";
						break;
					}
				default:
					{
						break;
					}
			}
			return item;
		}
	}
}
