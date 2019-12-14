using System;
using System.Collections.Generic;

namespace Product
{
    class Bread
    {
        public int BreadQuantity { get; set; }
        public int BreadCost { get; set; }
        public int BreadTotal { get; set; }

        public Bread(int breadQuantity)
        {
            BreadQuantity = breadQuantity;
            BreadCost = 5;
            BreadTotal = BreadCalculation();
        }

        public int BreadCalculation()
        {
            int breadOriginal = BreadQuantity /3;
            int BreadTotal = (BreadQuantity - breadOriginal) * BreadCost;
            return BreadTotal;
        }
    }

}