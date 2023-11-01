using Automaten.Model.ConnectionString;
using System;

namespace Automaten.Model
{
	internal class Drink
	{
		private List<string> _coffee = new List<string>();
		private List<string> _soda = new List<string>();
		private List<string> _sodaPrice = new List<string>();
		private List<string> _coffeePrice = new List<string>();
		private ReadDB readDB = new ReadDB();
		internal List<string> WhichSoda()
		{
			string SodaReader = "SELECT sodaName FROM Soda ORDER BY sodaID";
			_soda = readDB.GetDBInfo(SodaReader);
			return _soda;
		}
		internal List<string> SodaPrice()
		{
			string PriceReader = "SELECT sodaPrice FROM Soda";
			_sodaPrice = readDB.GetDBInfo(PriceReader);
			return _sodaPrice;
		}
		internal List<string> WhichCoffee()
		{
			string CoffeeReader = "SELECT coffeeName FROM Coffee ORDER BY coffeeID";
			 _coffee = readDB.GetDBInfo(CoffeeReader);
			return _coffee;
		}
		internal List<string> CoffeePrice()
		{
			string PriceReader = "SELECT coffeePrice FROM Coffee";
			_coffeePrice = readDB.GetDBInfo(PriceReader);
			return _coffeePrice;
		}
	}
}
