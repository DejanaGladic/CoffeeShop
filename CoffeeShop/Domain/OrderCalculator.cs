using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class OrderCalculator : ICalculator
    {
        public decimal CalculatedPrice { get; set; }
        public decimal CalculateTotalPrice(decimal Price)
        {
            return CalculatedPrice += Price;
        }
        public decimal CalculateDiscount(decimal Discount)
        {
            return CalculatedPrice *= (100-Discount)/100;
        }

        public decimal CalculateIncrease(decimal Increase)
        {
            return CalculatedPrice *= (100 + Increase) / 100;
        }
    }
}
