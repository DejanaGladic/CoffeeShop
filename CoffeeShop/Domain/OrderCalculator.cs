using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class OrderCalculator : ICalculator
    {
        public decimal calculatedPrice { get; set; }
        public decimal CalculateTotalPrice(decimal price)
        {
            return calculatedPrice += price;
        }
        public decimal CalculateDiscount(decimal discount)
        {
            return calculatedPrice *= (100-discount)/100;
        }

        public decimal CalculateIncrease(decimal increase)
        {
            return calculatedPrice *= (100 + increase) / 100;
        }
    }
}
