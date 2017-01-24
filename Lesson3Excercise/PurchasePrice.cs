using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Kett,Michael
//Lesson 2, Purchase Price
//1.23.2017

namespace Lesson3Excercise
{
    //  This class represents the purchase price of something. //  In our software project, we will use it to represent the price of //  one can of soda.
    class PurchasePrice
    {
         // private int _price = 0; Old value
        private decimal _price = 0M;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            Price = 0;
        }

        // This constructor allows a new purchase price to be set by the user
        // INT Version for legacy support
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        //Decimal Version
        public PurchasePrice(decimal intialPrice)
        {
            DecimalPrice = intialPrice;
        }

        //  This property gets the value the purchase price.
        public int Price
        {
            get { return (int)_price; }
            set { _price = value; }
        }

        //New Price Property to return Decimal
        public decimal DecimalPrice
        {
            get { return _price; }
            set { _price = value; }
        }
    }
} //end PurchasePrice