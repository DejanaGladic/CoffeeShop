using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class Coffee : ICoffee
    {
        public CoffeeName CoffeeName { get; set; }

        public CoffeeType CoffeeType { get; set; }

        public IEnumerable<string> Toppings { get; set; }

        public string ServiceType { get; set; }

        public decimal Price { get; set; }
    }
}
