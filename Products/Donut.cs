using System;
using System.Collections.Generic;

namespace Product.Donut //Need to brain storm a unique discount 
{
    class Donut
    {
        public int DonutQuantity { get; set; }
        public int DonutCost { get; set; }
        public int DonutTotal { get; set; }

        public Donut(int donutQuantity, Bread bread)
        {
            DonutQuantity = donutQuantity;
            DonutCost = 4; //Premium gold flake donuts!
            DonutTotal = DonutCalculation(bread);
        }

        public int DonutCalculation(Bread bread)
        {
            int breadQuantity = bread.BreadQuantity;
            return DonutTotal;
        }
    }

}