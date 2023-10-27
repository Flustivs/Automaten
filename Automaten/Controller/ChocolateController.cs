using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Controller
{
	internal class ChocolateController
	{
		Model.Snack snackClass = new Model.Snack();
		internal string PickChocolate(ConsoleKeyInfo Key)
		{
			List<string> chocolate = snackClass.WhichChocolate();
			string item = null;

			switch (Key.Key)
			{
				case ConsoleKey.D1:
					{
						item = chocolate[0];
						break;
					}
				case ConsoleKey.D2:
					{
						item = chocolate[1];
						break;
					}
				case ConsoleKey.D3:
					{
						item = chocolate[2];
						break;
					}
				case ConsoleKey.D4:
					{
						item = chocolate[3];
						break;
					}
				case ConsoleKey.D5:
					{
						item = chocolate[4];
						break;
					}
				case ConsoleKey.D6:
					{
						item = chocolate[5];
						break;
					}
				case ConsoleKey.D7:
					{
						item = chocolate[6];
						break;
					}
				case ConsoleKey.D8:
					{
						item = chocolate[7];
						break;
					}
				case ConsoleKey.D9:
					{
						item = chocolate[8];
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
