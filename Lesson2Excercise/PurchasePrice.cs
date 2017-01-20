using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Kett,Michael
//Lesson 2, Purchase Price
//1.18.2017

namespace Lesson2Excercise
{
    //  This class represents the purchase price of something. //  In our software project, we will use it to represent the price of //  one can of soda.
    class PurchasePrice
    {
        private int _price = 0;

        // This constructor sets the purchase price to zero
        public PurchasePrice()
        {
            Price = 35;
        }

        // This constructor allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        //  This property gets the value the purchase price.
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
} //end PurchasePrice