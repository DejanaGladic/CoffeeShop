namespace CoffeeShop.Domain
{
    public class Coffee
    {
        public CoffeeName CoffeeName { get; set; }

        public CoffeeType CoffeeType { get; set; }

        public List<string> Toppings { get; set; }

        public string ServiceType { get; set; }

        public decimal Price { get; set; }
    }
}
