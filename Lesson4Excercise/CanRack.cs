﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

//Kett,Michael
//Lesson 2, CanRack with optional
//1.23.2017


namespace Lesson4Excercise
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number
    // (e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    class CanRack
    {
        private const int  Emptybin = 0;
        private const int  Binsize = 3;
        Flavor flav; //Instantiate Enumeral Reference Variable
        
        //Converting flavors private fields to array
        //private int _regular = Emptybin;
        //private int _orange = Emptybin;
        //private int _lemon = Emptybin;

        private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length];

        // Constructor for a can rack. The rack starts out full

        public CanRack()
        {
            FillTheCanRack();
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            foreach (int i in Enum.GetValues(typeof(Flavor)))
            {
                rack[i] = Binsize;
            }

        }

        //  This method adds a can of the specified flavor to the rack.  
        public void AddACanOf(string flavorOfCanToBeAdded)
        {
            flavorOfCanToBeAdded = flavorOfCanToBeAdded.ToUpper();
            if (IsFull(flavorOfCanToBeAdded))
            {
                Debug.WriteLine($"*** Failed attempt to add a can of {flavorOfCanToBeAdded} to a full rack");
            }
            else
            {

                // Old Switch Statement
                //switch (flavorOfCanToBeAdded)
                //{
                //    case "REGULAR":
                //        _regular = _regular + 1;
                //        break;
                //    case "ORANGE":
                //        _orange = _orange + 1;
                //        break;
                //    case "LEMON":
                //        _lemon = _lemon + 1;
                //        break;
                //    default:
                //        Debug.WriteLine($"Error: attempt to add a can of unknown flavor {flavorOfCanToBeAdded} to the rack");
                //        break;
                //}
                if (Enum.TryParse(flavorOfCanToBeAdded, out flav))
                {
                    Debug.WriteLine($"adding a can of {flavorOfCanToBeAdded} flavored soda to the rack");
                    flav = (Flavor)Enum.Parse(typeof(Flavor), flavorOfCanToBeAdded);
                    int flavIndex = (int)flav;
                    rack[flavIndex]++; //Increment index record for flavorOfCanToBeAdded
                }
                else
                {
                    Debug.WriteLine($"Error: attempt to add a can of unknown flavor {flavorOfCanToBeAdded} to the rack");
                }
            }
        }

        //NEW Enumeration Style
        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string flavorOfCanToBeRemoved)
        {
            flavorOfCanToBeRemoved = flavorOfCanToBeRemoved.ToUpper();
            if (IsEmpty(flavorOfCanToBeRemoved))
            {
                Debug.WriteLine($"*** Failed attempt to remove a can of {flavorOfCanToBeRemoved} from an empty rack");
            }
            
                //Old Switch Statement
                //switch (flavorOfCanToBeRemoved)
                //{
                //    case "REGULAR":
                //        _regular = _regular - 1;
                //        break;
                //    case "ORANGE":
                //        _orange = _orange - 1;
                //        break;
                //    case "LEMON":
                //        _lemon = _lemon - 1;
                //        break;
                //    default:
                //        Debug.WriteLine($"Error: attempt to remove a can of unknown flavor {flavorOfCanToBeRemoved} from the rack");
                //        break;
                //}
                if (Enum.TryParse(flavorOfCanToBeRemoved, out flav))
                {
                    Debug.WriteLine($"removing a can of {flavorOfCanToBeRemoved} flavored soda from the rack");
                    flav = (Flavor)Enum.Parse(typeof(Flavor), flavorOfCanToBeRemoved);
                    int flavIndex = (int) flav;
                    rack[flavIndex]--; //Decrement index record for flavorOfCanToBeRemoved
                }
                else
                {
                    Debug.WriteLine($"Error: attempt to remove a can of unknown flavor {flavorOfCanToBeRemoved} from the rack");
                }
        }
        
        //NEW Enumeration Style
        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string flavorOfBinToCheck)
        {
            flavorOfBinToCheck = flavorOfBinToCheck.ToUpper();
            //Old Switch Style
            //switch (flavorOfBinToCheck)
            //{
            //    case "REGULAR":
            //        _regular = Emptybin;
            //        break;
            //    case "ORANGE":
            //        _orange = Emptybin;
            //        break;
            //    case "LEMON":
            //        _lemon = Emptybin;
            //        break;
            //    default:
            //        Debug.WriteLine($"Error: attempt to empty rack of unknown flavor {flavorOfBinToCheck}");
            //        break;
            //}
            if (Enum.TryParse(flavorOfBinToCheck, out flav)) //Check if 
            {
                Debug.WriteLine($"Emptying can rack of flavor {flavorOfBinToCheck}");
                flav = (Flavor)Enum.Parse(typeof(Flavor), flavorOfBinToCheck);
                rack[(int) flav] = Emptybin; //Set Index value to EmptyBin
            }
            else
            {
                Debug.WriteLine($"Error: attempt to empty rack of unknown flavor {flavorOfBinToCheck}");
            }

        }

        //NEW Enumeration Style
        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString());
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public bool IsFull(string flavorOfBinToCheck)
        {
            flavorOfBinToCheck = flavorOfBinToCheck.ToUpper();
            Debug.WriteLine($"Checking if can rack is full of flavor {flavorOfBinToCheck}");
            //OLD Switch Statement
            //switch (flavorOfBinToCheck)
            //{
            //    case "REGULAR":
            //        result = _regular == Binsize;
            //        break;
            //    case "ORANGE":
            //        result = _orange == Binsize;
            //        break;
            //    case "LEMON":
            //        result = _lemon == Binsize;
            //        break;
            //    default:
            //        Debug.WriteLine($"Error: attempt to check rack status of unknown flavor {flavorOfBinToCheck}");
            //        break;
            //}
            //return result;
            flav = (Flavor)Enum.Parse(typeof(Flavor), flavorOfBinToCheck);
            if (rack[(int)flav] == Binsize)
            {
                return true;
            }
            return false;
        }

        //NEW Enumeration Style
        public bool IsFull(Flavor FlavorOfBinToBeChecked)
        {
            return IsFull(FlavorOfBinToBeChecked.ToString());
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public bool IsEmpty(string flavorOfBinToCheck)
        {
            flavorOfBinToCheck = flavorOfBinToCheck.ToUpper();
            Debug.WriteLine($"Checking if can rack is empty of flavor {flavorOfBinToCheck}");
            //OLD Switch Style
            //switch (flavorOfBinToCheck)
            //{
            //    case "REGULAR":
            //        result = _regular == Emptybin;
            //        break;
            //    case "ORANGE":
            //        result = _orange == Emptybin;
            //        break;
            //    case "LEMON":
            //        result = _lemon == Emptybin;
            //        break;
            //    default:
            //        Debug.WriteLine($"Error: attempt to check rack status of unknown flavor {flavorOfBinToCheck}");
            //        break;
            //}
            //return result;
            flav = (Flavor)Enum.Parse(typeof(Flavor), flavorOfBinToCheck);
            if (rack[(int)flav] == Emptybin)
            {
                return true;
            }
            return false;
        }

        //NEW Enumeration Style
        public bool IsEmpty(Flavor FlavorOfBinToBeChecked)
        {
            return IsEmpty(FlavorOfBinToBeChecked.ToString());
        }

        // write out the contents of rack array. For example, one flavor per line with the flavor name and the number of cans of soda of that flavor. 
        // In a real system, this function would probably be in a 
        // separate class, and the CanRack would export this information as strings. We’re doing it this way 
        // for the sake of the simplicity of the exercise.
        public void DisplayCanRack()
        {
            Console.WriteLine("");
            Console.WriteLine("C# Vending Machine CanRack contents");
            foreach (string i in Enum.GetNames(typeof(Flavor)))
            {
                flav = (Flavor)Enum.Parse(typeof(Flavor), i);
                Console.WriteLine($"Number of Cans available for Flavor {i} is {rack[(int)flav]}");
            }
        }
    }

} //end CanRack
