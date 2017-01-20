using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


// Exercise 01 
// Author: Kett, Michael mgkett@gmail.com


namespace Lesson1Excercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sodaCost;
            int userInput;
            int errorHandle;
            errorHandle = 0;
            sodaCost = 35;
            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            while (errorHandle == 0)
            {
                Console.Write("Please insert " + sodaCost + " cents:");
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput < sodaCost)
                    {
                        Console.WriteLine(
                            "You have inserted " + userInput + " cents. " +
                            "The cost of a soda is " + sodaCost + " cents. " +
                            "You need an additional " + (sodaCost - userInput) + " cents next time! "
                        );
                    }
                    if (userInput == sodaCost)
                    {
                        Console.WriteLine(
                            "You have inserted " + userInput +
                            " cents. Thanks for using exact change!  Here is your soda. "
                        );
                        errorHandle = 1;
                    }
                    if (userInput > sodaCost)
                    {
                        Console.WriteLine(
                            "You have inserted " + userInput + " cents. " +
                            "The cost of a soda is " + sodaCost + " cents. " +
                            "Your change is " + (userInput - sodaCost) + " cents. "
                        );
                        errorHandle = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid number of cents!");
                }
            }
        }
    }
}
