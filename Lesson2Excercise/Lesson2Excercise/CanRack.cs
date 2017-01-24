using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

//Kett,Michael
//Lesson 2, CanRack with optional
//1.18.2017


namespace Lesson2Excercise
{
    //  This class will represent a can storage rack of the vending machine.  
    //  A can of soda will simply be represented as a number
    // (e.g., orangeCans = 1 means there is one can of orange soda in the rack).
    class CanRack
    {
        private const int  Emptybin = 0;
        private const int  Binsize = 3;

        private int _regular = Emptybin;
        private int _orange = Emptybin;
        private int _lemon = Emptybin;

        // Constructor for a can rack. The rack starts out full

        public CanRack()
        {
            FillTheCanRack();
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
                Debug.WriteLine($"adding a can of {flavorOfCanToBeAdded} flavored soda to the rack");
                switch (flavorOfCanToBeAdded)
                {
                    case "REGULAR":
                        _regular = _regular + 1;
                        break;
                    case "ORANGE":
                        _orange = _orange + 1;
                        break;
                    case "LEMON":
                        _lemon = _lemon + 1;
                        break;
                    default:
                        Debug.WriteLine($"Error: attempt to add a can of unknown flavor {flavorOfCanToBeAdded} to the rack");
                        break;
                }
            }
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string flavorOfCanToBeRemoved)
        {
            flavorOfCanToBeRemoved = flavorOfCanToBeRemoved.ToUpper();
            if (IsEmpty(flavorOfCanToBeRemoved))
            {
                Debug.WriteLine($"*** Failed attempt to remove a can of {flavorOfCanToBeRemoved} from an empty rack");
            }
            else
            {
                Debug.WriteLine($"removing a can of {flavorOfCanToBeRemoved} flavored soda from the rack");
                switch (flavorOfCanToBeRemoved)
                {
                    case "REGULAR":
                        _regular = _regular - 1;
                        break;
                    case "ORANGE":
                        _orange = _orange - 1;
                        break;
                    case "LEMON":
                        _lemon = _lemon - 1;
                        break;
                    default:
                        Debug.WriteLine($"Error: attempt to remove a can of unknown flavor {flavorOfCanToBeRemoved} from the rack");
                        break;
                }
            }
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            _regular = Binsize;
            _orange = Binsize;
            _lemon = Binsize;
        }


        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string flavorOfBinToCheck)
        {
            flavorOfBinToCheck = flavorOfBinToCheck.ToUpper();
            Debug.WriteLine($"Emptying can rack of flavor {flavorOfBinToCheck}");
            switch (flavorOfBinToCheck)
            {
                case "REGULAR":
                    _regular = Emptybin;
                    break;
                case "ORANGE":
                    _orange = Emptybin;
                    break;
                case "LEMON":
                    _lemon = Emptybin;
                    break;
                default:
                    Debug.WriteLine($"Error: attempt to empty rack of unknown flavor {flavorOfBinToCheck}");
                    break;
            }
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor
        // false otherwise
        public bool IsFull(string flavorOfBinToCheck)
        {
            flavorOfBinToCheck = flavorOfBinToCheck.ToUpper();
            var result = false;
            Debug.WriteLine($"Checking if can rack is full of flavor {flavorOfBinToCheck}");
            switch (flavorOfBinToCheck)
            {
                case "REGULAR":
                    result = _regular == Binsize;
                    break;
                case "ORANGE":
                    result = _orange == Binsize;
                    break;
                case "LEMON":
                    result = _lemon == Binsize;
                    break;
                default:
                    Debug.WriteLine($"Error: attempt to check rack status of unknown flavor {flavorOfBinToCheck}");
                    break;
            }
            return result;

        }

        // OPTIONAL – return true if the rack is empty of a specified flavor
        // false otherwise 
        public bool IsEmpty(string flavorOfBinToCheck)
        {
            flavorOfBinToCheck = flavorOfBinToCheck.ToUpper();
            var result = false;
            Debug.WriteLine($"Checking if can rack is empty of flavor {flavorOfBinToCheck}");
            switch (flavorOfBinToCheck)
            {
                case "REGULAR":
                    result = _regular == Emptybin;
                    break;
                case "ORANGE":
                    result = _orange == Emptybin;
                    break;
                case "LEMON":
                    result = _lemon == Emptybin;
                    break;
                default:
                    Debug.WriteLine($"Error: attempt to check rack status of unknown flavor {flavorOfBinToCheck}");
                    break;
            }
            return result;
        }

    }

} //end CanRack
