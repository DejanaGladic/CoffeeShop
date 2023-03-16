namespace CoffeeShop.Interfaces
{
    public interface ICalculator
    {
        public decimal CalculateTotalPrice(decimal price);

        public decimal CalculateDiscount(decimal Discount);

        public decimal CalculateIncrease(decimal Increase)
    }
}
