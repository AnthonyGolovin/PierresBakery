using System;
using System.Collections.Generic;

namespace Product.Donut //Need to brain storm a unique discount 
{
    class Donut
    {
        public int DonutQuantity { get; set; }
        public int DonutCost { get; set; }
        public int DonutTotal { get; set; }

        public Donut(int donutQuantity)
        {
            DonutQuantity = donutQuantity;
            DonutCost = 4; //Premium gold flake donuts!
            DonutTotal = DonutCalculation();
        }

        public int DonutCalculation()
        {
            
            return DonutTotal;
        }
    }

}