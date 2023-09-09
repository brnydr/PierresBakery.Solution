using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
   static void Main()
   {
      Console.BackgroundColor = ConsoleColor.Green;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread is $5 dollars per loaf, and every 3rd loaf is free!");
      Console.WriteLine("Pastries are $2 a piece, and every 4th pastry is free!");
      Console.WriteLine("Enter how many loaves of bread you'd like using numerals:");
      int breadInput = int.Parse(Console.ReadLine());
      Console.WriteLine("And nowwwww...enter how many pastries you'd prefer(also using numerals):");
      int pastryInput = int.Parse(Console.ReadLine());
      Bread newBread = new Bread();
      int breadTotal = newBread.CalculateTotal(breadInput);
      Pastry newPastry = new Pastry();
      int pastryTotal = newPastry.CalculateTotal(pastryInput);
      Console.WriteLine("Your total for bread is $" + breadTotal + " and your total for pastries is $" + pastryTotal + ". Your grand total is $" + (breadTotal + pastryTotal) + ". Thank you for your patronage!");
   }
  }
}