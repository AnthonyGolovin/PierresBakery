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
            int breadQuantity = bread.BreadQuantity;//return
            int price = 0;
        if (((breadQuantity / 2) - DonutQuantity) < 0) {
            price = 0;
        } else {
            price =  ((breadQuantity / 2) - DonutQuantity)* DonutCost;
        } 
        return price;
        }
    }

}