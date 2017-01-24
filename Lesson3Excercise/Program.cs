using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kett,Michael
//Lesson 2, Main program
//1.23.2017

namespace Lesson3Excercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PurchasePrice sodaCost = new PurchasePrice(35);
            PurchasePrice sodaCostDecimal = new PurchasePrice(0.35M);
            CanRack sodaRack = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.WriteLine($"Please insert {sodaCost.Price} cents: (old version)");
            int userInput = int.Parse(Console.ReadLine()); //Changed this to int.Parse per David Blodgett's feedback
            Console.WriteLine($"You have inserted {userInput} cents. Thanks, Here is your soda.");
            Console.Write($"Please insert {sodaCostDecimal.DecimalPrice} cents: (New version)");
            decimal userInput2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"You have inserted {userInput2:c} cents. Thanks, Here is your soda.");
            sodaRack.RemoveACanOf("REGULAR");
        }
    }
}
