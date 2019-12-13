using System;
using System.Collections.Generic;

namespace Product.Pastry
{
    class Pastry
    {
        public int PastryQuantity { get; set; }
        public int PastryCost { get; set; }
        public int PastryTotal { get; set; }
        public int PastryDiscount { get; set; }

        public Pastry(int pastryQuantity, int pastryCost)
        {
            PastryQuantity = pastryQuantity;
            PastryCost = 2;
            PastryTotal = PastryCalculation();
            PastryDiscount = 5;
        }

        public int PastryCalculation()
        {
            int remainder = PastryQuantity % 3;
            int Promotion = PastryQuantity / 3;
            int PastryTotal = (PastryCost * remainder) + (Promotion * PastryDiscount);
            return PastryTotal;
        }
    }

}