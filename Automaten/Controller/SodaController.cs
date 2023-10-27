using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Controller
{
	internal class SodaController
	{
		Model.Drink drinkClass = new Model.Drink();
		internal string PickSoda(ConsoleKeyInfo Key)
		{
			List<string> soda = drinkClass.WhichSoda();
			string item = null;

			switch (Key.Key)
			{
				case ConsoleKey.D1:
					{
						item = soda[0];
						break;
					}
				case ConsoleKey.D2:
					{
						item = soda[1];
						break;
					}
				case ConsoleKey.D3:
					{
						item = soda[2];
						break;
					}
				case ConsoleKey.D4:
					{
						item = soda[3];
						break;
					}
				case ConsoleKey.D5:
					{
						item = soda[4];
						break;
					}
				case ConsoleKey.D6:
					{
						item = soda[5];
						break;
					}
				case ConsoleKey.D7:
					{
						item = soda[6];
						break;
					}
				case ConsoleKey.D8:
					{
						item = soda[7];
						break;
					}
				case ConsoleKey.D9:
					{
						item = soda[8];
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
