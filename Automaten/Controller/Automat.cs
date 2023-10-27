using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Controller
{
	internal class Automat
	{
		View.Menu menu = new View.Menu();
		Model.Drink drinkPriceClass = new Model.Drink();
		Model.Drink drinkNameClass = new Model.Drink();
		Model.Snack snackPriceClass = new Model.Snack();
		Model.Snack snackNameClass = new Model.Snack();
		Model.ReadDB readDB = new Model.ReadDB();
		Controller.ChipBagController chipBagController = new Controller.ChipBagController();
		Controller.ChocolateController chocolateController = new Controller.ChocolateController();
		Controller.CoffeeController coffeeController = new Controller.CoffeeController();
		Controller.SodaController sodaController = new Controller.SodaController();



		internal void VendingMachine()
		{
			string product = "";
			bool vending = true;
			bool eight = false;
			bool seven = false;
			while (vending)
			{
				ConsoleKeyInfo key = menu.StartMenu();
				switch (key.Key)
				{
					case ConsoleKey.D1:
						{
							ConsoleKeyInfo drinksKey = menu.DrinksMenu();
							switch (drinksKey.Key)
							{
								// This switch switches between coffee and soda and then looks for what key the user have pressed
								// So it can determind the price of that product and then lets the user pay for it
								case ConsoleKey.D1:
									{
										ConsoleKeyInfo sodaKey = menu.SodaMenu(drinkNameClass.WhichSoda(), drinkPriceClass.SodaPrice());
										product = sodaController.PickSoda(sodaKey);
										List<string> listPrice = readDB.GetDBInfo($"SELECT sodaPrice FROM Soda WHERE sodaName = '{product}'");
										float price = float.Parse(listPrice[0]);
										menu.BuyMenu(product, price);
										break;
									}
								case ConsoleKey.D2:
									{
										ConsoleKeyInfo coffeeKey = menu.CoffeeMenu(drinkNameClass.WhichCoffee(), drinkPriceClass.CoffeePrice());
										product = coffeeController.PickCoffee(coffeeKey);
										List<string> listPrice = readDB.GetDBInfo($"SELECT coffeePrice FROM Coffee WHERE coffeeName = '{product}'");
										float price = float.Parse(listPrice[0]);
										menu.BuyMenu(product, price);
										break;
									}
							}
							break;
						}
					case ConsoleKey.D2:
						{
							// This switch switches between chocolate and chipbags and then looks for what key the user have pressed
							// So it can determind the price of that product and then lets the user pay for it
							ConsoleKeyInfo snackKey = menu.SnackMenu();
							switch (snackKey.Key)
							{
								case ConsoleKey.D1:
									{
										ConsoleKeyInfo chocolateKey = menu.ChocolateMenu(snackNameClass.WhichChocolate(), snackPriceClass.ChocolatePrice());
										product = chocolateController.PickChocolate(chocolateKey);
										List<string> listPrice = readDB.GetDBInfo($"SELECT chocolatePrice FROM Chocolate WHERE chocolateName = '{product}'");
										float price = float.Parse(listPrice[0]);
										menu.BuyMenu(product, price);
										break;
									}
								case ConsoleKey.D2:
									{
										ConsoleKeyInfo chipBagKey = menu.ChipBagMenu(snackNameClass.WhichChipBag(), snackPriceClass.ChipBagPrice());
										product = chipBagController.PickChipBag(chipBagKey);
										List<string> listPrice = readDB.GetDBInfo($"SELECT chipBagPrice FROM ChipBag WHERE chipBagName = '{product}'");
										float price = float.Parse(listPrice[0]);
										menu.BuyMenu(product, price);
										break;
									}
							}
							break;
						}
					case ConsoleKey.D7:
						{
							seven = true;
							break;
						}
					case ConsoleKey.D8:
						{
							eight = true;
							break;
						}
					case ConsoleKey.D0:
						{
							if (eight && seven)
							{
								ConsoleKeyInfo Adminkey = menu.AdminPage();
								switch (Adminkey.Key)
								{
									case ConsoleKey.D1:
										{
											ConsoleKeyInfo SodaKey = menu.SodaMenu(drinkNameClass.WhichSoda(), drinkPriceClass.SodaPrice());
											product = sodaController.PickSoda(SodaKey);
											List<string> listPrice = readDB.GetDBInfo($"SELECT sodaPrice FROM Soda WHERE sodaName = '{product}'");
											float price = float.Parse(listPrice[0]);
											float changedPrice = menu.PriceChanger(price, product);
											readDB.GetDBInfo($"UPDATE Soda SET sodaPrice = '{changedPrice}' WHERE sodaName = '{product}'");
											Thread.Sleep(1500);
											break;
										}
									case ConsoleKey.D2:
										{
											ConsoleKeyInfo CoffeeKey = menu.CoffeeMenu(drinkNameClass.WhichCoffee(), drinkPriceClass.CoffeePrice());
											product = coffeeController.PickCoffee(CoffeeKey);
											List<string> listPrice = readDB.GetDBInfo($"SELECT coffeePrice FROM Coffee WHERE coffeeName = '{product}'");
											float price = float.Parse(listPrice[0]);
											float changedPrice = menu.PriceChanger(price, product);
											readDB.GetDBInfo($"UPDATE Coffee SET coffeePrice = '{changedPrice}' WHERE coffeeName = '{product}'");
											Thread.Sleep(1500);
											break;
										}
									case ConsoleKey.D3:
										{
											ConsoleKeyInfo ChocolateKey = menu.ChocolateMenu(snackNameClass.WhichChocolate(), snackPriceClass.ChocolatePrice());
											product = chocolateController.PickChocolate(ChocolateKey);
											List<string> listPrice = readDB.GetDBInfo($"SELECT chocolatePrice FROM Chocolate WHERE chocolateName = '{product}'");
											float price = float.Parse(listPrice[0]);
											float changedPrice = menu.PriceChanger(price, product);
											readDB.GetDBInfo($"UPDATE Chocolate SET chocolatePrice = '{changedPrice}' WHERE chocolateName = '{product}'");
											Thread.Sleep(1500);
											break;
										}
									case ConsoleKey.D4:
										{
											ConsoleKeyInfo ChipBagKey = menu.ChipBagMenu(snackNameClass.WhichChipBag(), snackPriceClass.ChipBagPrice());
											product = chipBagController.PickChipBag(ChipBagKey);
											List<string> listPrice = readDB.GetDBInfo($"SELECT chipBagPrice FROM ChipBag WHERE chipBagName = '{product}'");
											float price = float.Parse(listPrice[0]);
											float changedPrice = menu.PriceChanger(price, product);
											readDB.GetDBInfo($"UPDATE ChipBag SET chipBagPrice = '{changedPrice}' WHERE chipBagName = '{product}'");
											Thread.Sleep(1500);
											break;
										}
								}
							}
							break;
						}
					default:
						{
							eight = false;
							seven = false;
							break;
						}
				}
			}
		}
	}
}
