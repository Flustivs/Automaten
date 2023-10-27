using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Controller
{
	internal class ChipBagController
	{
		Model.Snack snackClass = new Model.Snack();
		internal string PickChipBag(ConsoleKeyInfo Key)
		{
			List<string> chipBag = snackClass.WhichChipBag();
			string item = null;

			switch (Key.Key)
			{
				case ConsoleKey.D1:
					{
						item = chipBag[0];
						break;
					}
				case ConsoleKey.D2:
					{
						item = chipBag[1];
						break;
					}
				case ConsoleKey.D3:
					{
						item = chipBag[2];
						break;
					}
				case ConsoleKey.D4:
					{
						item = chipBag[3];
						break;
					}
				case ConsoleKey.D5:
					{
						item = chipBag[4];
						break;
					}
				case ConsoleKey.D6:
					{
						item = chipBag[5];
						break;
					}
				case ConsoleKey.D7:
					{
						item = chipBag[6];
						break;
					}
				case ConsoleKey.D8:
					{
						item = chipBag[7];
						break;
					}
				case ConsoleKey.D9:
					{
						item = chipBag[8];
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
