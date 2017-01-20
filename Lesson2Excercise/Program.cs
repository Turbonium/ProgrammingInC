using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kett,Michael
//Lesson 2, Main program
//1.18.2017

namespace Lesson2Excercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PurchasePrice sodaCost = new PurchasePrice(35);
            CanRack sodaRack = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write($"Please insert {sodaCost.Price} cents:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have inserted {userInput} cents. Thanks, Here is your soda.");
            sodaRack.RemoveACanOf("REGULAR");


            //Test of Adding to the Rack
            sodaRack.AddACanOf("REGULAR");
            sodaRack.AddACanOf("REGULAR");
            sodaRack.AddACanOf("REGULAR");
            sodaRack.AddACanOf("REGULAR");

            //Test of Removing from the Rack
            sodaRack.RemoveACanOf("REGULAR");
            sodaRack.RemoveACanOf("REGULAR");
            sodaRack.RemoveACanOf("REGULAR");
            sodaRack.RemoveACanOf("REGULAR");

        }
    }
}
