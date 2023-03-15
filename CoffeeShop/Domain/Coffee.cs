using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Domain
{
    public class Coffee
    {
        public CoffeeName CoffeeName { get; set; }

        public CoffeeType CoffeeType { get; set; }

        public double Price { get; set; }

        public void incrementPrice(double IncrementValue) {
            this.Price += IncrementValue;
        }
    }
}
