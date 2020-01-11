using System;
using System.Collections.Generic;
using Product;

namespace Product //Need to brain storm a unique discount 
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
            int FreeDonuts = bread.BreadQuantity/2;
            if (DonutQuantity > FreeDonuts) {
                
            DonutTotal = (DonutQuantity-FreeDonuts)*DonutCost;
            } else {
                DonutTotal = 0;
            }
        return DonutTotal;
        }
    }

}