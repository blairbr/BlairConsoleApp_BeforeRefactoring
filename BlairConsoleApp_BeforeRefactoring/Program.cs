// This app takes in a user input for the price of an item and how much the customer paid with, and returns the amount of change to be given to the customer.

using System;
using System.Dynamic;

namespace BlairConsoleApp_BeforeRefactoring
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter price in dollars: ");
			int priceinDollarsAsCents = Convert.ToInt32(Console.ReadLine()) * 100;

			Console.WriteLine("Enter price in cents: ");
			int priceInCents = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter money received in dollars: ");
			int recievedDollarsAsCents = Convert.ToInt32(Console.ReadLine()) * 100;

			Console.WriteLine("Enter money received in cents: ");
			int recievedCents = Convert.ToInt32(Console.ReadLine());


			int totalRecieved = recievedCents + recievedDollarsAsCents;
			int totalPrice = priceInCents + priceinDollarsAsCents;
			int changeToReturn = totalRecieved - totalPrice;

			if (totalRecieved > totalPrice)
			{
				int dollarstoReturn = changeToReturn / 100;
				int centsRemainingAfterDollars = changeToReturn % 100;
				int centsRemaining = centsRemainingAfterDollars;

				int quartersToReturn = centsRemaining / 25;
				centsRemaining = centsRemaining % 25;

				int dimesToReturn = centsRemaining / 10;
				centsRemaining = centsRemaining % 10;

				int nickelsToReturn = centsRemaining / 5;
				int penniesToReturn = centsRemaining % 5;

				Console.WriteLine($"Your change is {dollarstoReturn} dollar(s) and {centsRemainingAfterDollars} cents. ");

				Console.WriteLine("Dollars: " + dollarstoReturn);
				Console.WriteLine("Quarters: " + quartersToReturn);
				Console.WriteLine("Dimes: " + dimesToReturn);
				Console.WriteLine("Nickels: " + nickelsToReturn);
				Console.WriteLine("Pennies: " + penniesToReturn);
			}

			else if (totalRecieved == totalPrice)
			{
				Console.WriteLine("No change for you");
			}

			else
			{
				int amountOwed = totalPrice - totalRecieved;
				int dollarsOwed = amountOwed / 100;
				int centsOwed = amountOwed % 100;
				Console.WriteLine($"You still owe {amountOwed} cents, AKA {dollarsOwed} dollar(s) and {centsOwed} cents");
			}

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}