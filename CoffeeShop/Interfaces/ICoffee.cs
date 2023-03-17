using CoffeeShop.Domain;

namespace CoffeeShop.Interfaces
{
    public interface ICoffee
    {
        CoffeeName CoffeeName { get; set; }
        CoffeeType CoffeeType { get; set; }
        decimal Price { get; set; }
        string ServiceType { get; set; }
        IEnumerable<string> Toppings { get; set; }
    }
}