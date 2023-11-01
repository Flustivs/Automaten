using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.View
{
	internal class Menu
	{
		private ConsoleKey[] checkKey = { ConsoleKey.D0, ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.D4, ConsoleKey.D5, ConsoleKey.D6, ConsoleKey.D7, ConsoleKey.D8, ConsoleKey.D9 };
        internal ConsoleKeyInfo StartMenu()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			string menu = "=========================================\n" +
						  "             Vending machine             \n" +
						  "=========================================\n\n" +
						  "(You need to use the keys from 1 - 2 to navigate between menus)\n\n" +
						  "1. Drinks\n" +
						  "2. Snacks";
			Console.WriteLine(menu);
			ConsoleKeyInfo Key = Console.ReadKey();
			return Key;
		}
		internal ConsoleKeyInfo DrinksMenu()
		{
			Console.Clear();
			string menu = "=========================================\n" +
							"                  Drinks                 \n" +
							"=========================================\n\n" +
							"1. Soda\n" +
							"2. Coffee";
			Console.WriteLine(menu);
			ConsoleKeyInfo key = Console.ReadKey();
			return key;
		}
		internal ConsoleKeyInfo SodaMenu(List<string> info, List<string> price)
		{
			bool sodas = true;
			ConsoleKeyInfo key = new ConsoleKeyInfo();
			while (sodas)
			{
				Console.Clear();
				string menu = "=========================================\n" +
							  "                  Sodas                  \n" +
							  "=========================================\n";
				Console.WriteLine(menu);
				int i = 1;
				foreach (string item in info)
				{
					for (int o = 0; o < 1; o++)
					{
						Console.ForegroundColor = (ConsoleColor)i;
						Console.WriteLine($"{i}: {item} {price[i - 1]} DKK");
						Console.ForegroundColor = ConsoleColor.White;
					}
					i++;
				}
				Console.WriteLine("0: Exit");
				key = Console.ReadKey();
				for (int o = 0; o <= 8; o++)
				{
					if (key.Key == checkKey[o])
					{
						sodas = false;
						break;
					}
				}
				if (sodas)
				{
					Console.WriteLine("\nInvalid Input");
					Thread.Sleep(1500);
				}
			}
			return key;
		}
		internal ConsoleKeyInfo CoffeeMenu(List<string> info, List<string> price)
		{
			bool coffee = true;
			ConsoleKeyInfo key = new ConsoleKeyInfo();
			while (coffee)
			{
				Console.Clear();
				string menu = "=========================================\n" +
							  "                 Coffee                  \n" +
							  "=========================================\n";
				Console.WriteLine(menu);
				int i = 1;
				foreach (string item in info)
				{
					for (int o = 0; o < 1; o++)
					{
						Console.ForegroundColor = (ConsoleColor)i;
						Console.WriteLine($"{i}: {item} {price[i - 1]} DKK");
						Console.ForegroundColor = ConsoleColor.White;
					}
					i++;
				}
				Console.WriteLine("0: Exit");
				key = Console.ReadKey();
				for (int o = 0; o <= 8; o++)
				{
					if (key.Key == checkKey[o])
					{
						coffee = false;
						break;
					}
				}
				if (coffee)
				{
					Console.WriteLine("\nInvalid Input");
					Thread.Sleep(1500);
				}
			}
			return key;
		}
		internal ConsoleKeyInfo SnackMenu()
		{
			Console.Clear();
			string menu = "=========================================\n" +
							"                  Snacks                 \n" +
							"=========================================\n\n" +
							"1. Chocolate\n" +
							"2. ChipBag";
			Console.WriteLine(menu);
			ConsoleKeyInfo key = Console.ReadKey();
			return key;
		}
		internal ConsoleKeyInfo ChocolateMenu(List<string> info, List<string> price)
		{
			bool chocolate = true;
			ConsoleKeyInfo key = new ConsoleKeyInfo();
			while (chocolate)
			{
				Console.Clear();
				string menu = "=========================================\n" +
							  "                Chocolate                \n" +
							  "=========================================\n";
				Console.WriteLine(menu);
				int i = 1;
				foreach (string item in info)
				{
					for (int o = 0; o < 1; o++)
					{
						Console.ForegroundColor = (ConsoleColor)i;
						Console.WriteLine($"{i}: {item} {price[i - 1]} DKK");
						Console.ForegroundColor = ConsoleColor.White;
					}
					i++;
				}
				Console.WriteLine("0: Exit");
				key = Console.ReadKey();
				for (int o = 0; o <= 8; o++)
				{
					if (key.Key == checkKey[o])
					{
						chocolate = false;
						break;
					}
				}
				if (chocolate)
				{
					Console.WriteLine("\nInvalid Input");
					Thread.Sleep(1500);
				}
			}
			return key;
		}
		internal ConsoleKeyInfo ChipBagMenu(List<string> info, List<string> price)
		{
			bool chipBag = true;
			ConsoleKeyInfo key = new ConsoleKeyInfo();
			while (chipBag)
			{
				Console.Clear();
				string menu = "=========================================\n" +
							  "                 ChipBag                 \n" +
							  "=========================================\n";
				Console.WriteLine(menu);
				int i = 1;
				foreach (string item in info)
				{
					for (int o = 0; o < 1; o++)
					{
						Console.ForegroundColor = (ConsoleColor)i;
						Console.WriteLine($"{i}: {item} {price[i - 1]} DKK");
						Console.ForegroundColor = ConsoleColor.White;
					}
					i++;
				}
				Console.WriteLine("0: Exit");
				key = Console.ReadKey();
				for (int o = 0; o <= 8; o++)
				{
					if (key.Key == checkKey[o])
					{
						chipBag = false;
						break;
					}
				}
				if (chipBag)
				{
					Console.WriteLine("\nInvalid Input");
					Thread.Sleep(1500);
				}
			}
			return key;
		}
		internal bool BuyMenu(string product, float price)
		{
			Console.Clear();
			bool enoughMoney = false;
			string menu = "=========================================\n" +
						  "                    Buy                  \n" +
						  "=========================================\n\n" +
						  "Please enter the amount of money you have";
			Console.WriteLine(menu);
			float transaction = 0;
			try
			{
				transaction = float.Parse(Console.ReadLine());
				enoughMoney = GiveProduct(product, price, transaction);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return enoughMoney;
		}
		private bool GiveProduct(string product, float price, float change)
		{
			Console.Clear();
			bool enoughMoney = false;
			change = change - price;
			if (change < 0)
			{
				IncorrectAmount(change);
			}
			else
			{
				string givingProduct = "=========================================\n" +
									   "                 Product                 \n" +
									   "=========================================\n\n" +
									   $"Product = {product}\nPrice = {price}\n\nThis is your change {change}\n";
				Console.WriteLine(givingProduct);
				enoughMoney = true;
				Thread.Sleep(3000);
			}
			return enoughMoney;
		}
		private void IncorrectAmount(float transaction)
		{
			string notEnough = "=========================================\n" +
							   "                 Product                 \n" +
							   "=========================================\n\n" +
							   $"you still need {transaction * -1}";
			Console.WriteLine(notEnough);
			Thread.Sleep(3500);
		}
		internal ConsoleKeyInfo AdminPage()
		{
			Console.Clear();
			string adminMenu = "=========================================\n" +
							   "                  Admin                  \n" +
							   "=========================================\n\n" +
							   "1. Sodas\n" +
							   "2. Coffee\n" +
							   "3. Chocolate\n" +
							   "4. ChipBag\n" +
							   "5. Restock All";
			Console.WriteLine(adminMenu);
			ConsoleKeyInfo key = Console.ReadKey();
			return key;
		}
		internal float PriceChanger(float price, string product)
		{
			Console.Clear();
			float wantedPrice = 0;
			string priceChangerPage = "=========================================\n" +
								 "                  Admin                  \n" +
								 "=========================================\n\n" +
								 $"The current price of {product} is {price}?";
			Console.WriteLine(priceChangerPage);
			try
			{
				wantedPrice = float.Parse(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return wantedPrice;
		}
	}
}
