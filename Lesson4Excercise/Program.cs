using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Kett,Michael
//Lesson 2, Main program
//1.23.2017

namespace Lesson4Excercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PurchasePrice sodaCost = new PurchasePrice(35);
            PurchasePrice sodaCostDecimal = new PurchasePrice(0.35M);
            CanRack sodaRack = new CanRack();
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            bool exitVend = false;
            Prompt promptYN;

            while (exitVend != true)
            {
                //Console.WriteLine($"Please insert {sodaCost.Price} cents: (old version)");
                //int userInput = int.Parse(Console.ReadLine()); //Changed this to int.Parse per David Blodgett's feedback
                //Console.WriteLine($"You have inserted {userInput} cents. Thanks, Here is your soda.");
                Console.Write($"Please insert {sodaCostDecimal.DecimalPrice} cents: ");
                decimal userInput2 = decimal.Parse(Console.ReadLine());
                if (!sodaRack.IsEmpty(Flavor.REGULAR))
                {
                    Console.WriteLine($"You have inserted {userInput2:c} cents. Thanks, Here is your soda.");
                    sodaRack.RemoveACanOf(Flavor.REGULAR);
                }
                else
                {
                    Console.WriteLine(
                        $"Sorry, We're out flavor {Flavor.REGULAR}, Unable to process your request!  Exiting!");
                    break;
                }
                Console.Write("Would you like to stop the vending machine and return results of remaining Sodas? (Y/N)");
                string userResponse = Console.ReadLine().ToUpper();
                if (Enum.TryParse(userResponse, out promptYN))
                {
                    if (userResponse.StartsWith("Y"))
                    {
                        exitVend = true;
                        Console.Write("You Chose to stop using the vending machine!");
                    }
                }
                else
                {
                    Console.WriteLine("Please Type in a valid Y/N value! (Yes, Y, No, N)");
                }
            }
            sodaRack.DisplayCanRack();
        }
    }
}
