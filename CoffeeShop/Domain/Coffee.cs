namespace CoffeeShop.Domain
{
    public class Coffee
    {
        public CoffeeName CoffeeName { get; set; }

        public CoffeeType CoffeeType { get; set; }

        public decimal Price { get; set; }

        public void IncrementCoffeePrice(decimal ValueToIncrement) { 
            Price += ValueToIncrement;
        }
    }
}
