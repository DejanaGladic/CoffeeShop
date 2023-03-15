using CoffeeShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Domain
{
    public class Calculator : ICalculator
    {
        public void calculateCoffeePrice(Coffee orderedCoffee)
        {
            double addPrice;
            switch (orderedCoffee.CoffeeName)
            {
                case CoffeeName.Espresso:
                    addPrice = 1.2;
                break;
                case CoffeeName.Cappuccino:
                    addPrice = 2;
                break;
                case CoffeeName.LatteMacchiato:
                    addPrice = 2.5;
                break;
                default:
                    addPrice = 0;
                break;
            }
            orderedCoffee.incrementPrice(addPrice);
        }

        public void calculateCoffeeType(Coffee orderedCoffee)
        {
            if (CoffeeType.Large == orderedCoffee.CoffeeType) {
                orderedCoffee.Price += 0.7;
            }
        }
    }
}
