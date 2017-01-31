using System;
using System.Collections.Generic;
using System.Data;
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
            bool exitVend = false;
            Prompt promptYN;
            Flavor flavorChoice;

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");


            while (exitVend != true)
            {
                //First Display Can amounts
                sodaRack.DisplayCanRack();
                Console.WriteLine("-----------------------------------");
                Console.Write($"Please insert {sodaCostDecimal.DecimalPrice} cents: ");
                
                //Begin Coin Selection Region
                decimal coinValuesInserted = 0M;
                while (coinValuesInserted < sodaCostDecimal.DecimalPrice)
                {
                    decimal valueNeeded = sodaCostDecimal.DecimalPrice - coinValuesInserted;
                    Console.WriteLine($"You have a total coin value of {coinValuesInserted}.  You need to insert an additional {valueNeeded:c}");
                    string nameOfCoinInserted = Console.ReadLine().ToUpper();
                    Coin coinInserted = new Coin(nameOfCoinInserted);
                    Console.WriteLine($"You inserted a {coinInserted} with a value of {coinInserted.ValueOf:c}");
                    coinValuesInserted += coinInserted.ValueOf;
                }
                //End Coin Selection Region

                //Begin Flavor Selection Region
                Console.Clear();
                sodaRack.DisplayCanRack();
                Console.WriteLine("Please choose a flavor by Availability:");
                string flavorChosen = Console.ReadLine().ToUpper();
                if (Enum.TryParse(flavorChosen, out flavorChoice))
                {
                    if (!sodaRack.IsEmpty(flavorChoice))
                    {
                        sodaRack.RemoveACanOf(flavorChoice);
                        Console.WriteLine($"Thanks, here is your can of {flavorChoice}");
                    }
                    else
                    {
                        Console.WriteLine(
                            $"Sorry, We're out flavor {flavorChoice}, Unable to process your request!  Choose a Different Flavor!");

                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please Choose a proper flavor");
                }

                //END Flavor Selection Region

                //Exit Vending Machine Region

                Console.Write(
                    "Would you like to stop the vending machine and return results of remaining Sodas? (Y/N)");
                string userResponse = Console.ReadLine().ToUpper();
                if (Enum.TryParse(userResponse, out promptYN))
                {
                    if (userResponse.StartsWith("Y"))
                    {
                        Console.Clear();
                        Console.Write("You Chose to stop using the vending machine!");
                        sodaRack.DisplayCanRack();
                        break;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please Type in a valid Y/N value! (Yes, Y, No, N)");
                }

            // END Exit Vending Machine Region

            }

        }
    }
}
