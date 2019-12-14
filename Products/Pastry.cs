using System;
using System.Collections.Generic;

namespace Product
{
    class Pastry
    {
        public int PastryQuantity { get; set; }
        public int PastryCost { get; set; }
        public int PastryTotal { get; set; }
        public int PastryDiscount { get; set; }

        public Pastry(int pastryQuantity) //Dont add pastry cost in arguements its just gonna be over written by the constructor price (Note to self)
        {
            PastryQuantity = pastryQuantity;
            PastryCost = 2;
            PastryTotal = PastryCalculation();
            PastryDiscount = 5;
        }

        public int PastryCalculation()
        {     
            return (PastryQuantity % 3) * 5 + (PastryQuantity - (PastryQuantity % 3)) * 2;
        }
    }

}