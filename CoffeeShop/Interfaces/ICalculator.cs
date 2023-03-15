using CoffeeShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Interfaces
{
    public interface ICalculator
    {
        public void calculateCoffeePrice(Coffee orderedCoffee);
        public void calculateCoffeeType(Coffee orderedCoffee);
    }
}
