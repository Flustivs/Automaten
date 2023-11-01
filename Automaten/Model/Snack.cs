using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Model
{
	internal class Snack
	{
		private List<string> _chocolate = new List<string>();
		private List<string> _chipBag = new List<string>();
		private List<string> _chocolatePrice = new List<string>();
		private List<string> _chipBagPrice = new List<string>();
		ReadDB readDB = new ReadDB();

		internal List<string> WhichChocolate()
		{
			string ChocolateReader = "SELECT chocolateName FROM Chocolate ORDER BY chocolateID";
			_chocolate = readDB.GetDBInfo(ChocolateReader);
			return _chocolate;
		}
		internal List<string> ChocolatePrice()
		{
			string chocolatePrice = "SELECT chocolatePrice FROM Chocolate";
			_chocolatePrice = readDB.GetDBInfo(chocolatePrice);
			return _chocolatePrice;
		}
		internal List<string> WhichChipBag()
		{
			string ChipBagreader = "SELECT chipBagName FROM ChipBag ORDER BY chipBagID";
			_chipBag = readDB.GetDBInfo(ChipBagreader);
			return _chipBag;	
		}
		internal List<string> ChipBagPrice()
		{
			string chipBagPrice = "SELECT chipBagPrice FROM ChipBag";
			_chipBagPrice = readDB.GetDBInfo (chipBagPrice);
			return _chipBagPrice;
		}
	}
}
