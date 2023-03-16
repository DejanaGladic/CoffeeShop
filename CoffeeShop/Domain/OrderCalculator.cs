using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class OrderCalculator : ICalculator
    {
        public decimal CalculatedPrice { get; set; }
        public decimal CalculateTotalPrice(decimal price)
        {
            return CalculatedPrice += price;
        }
    }
}
