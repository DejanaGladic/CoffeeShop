
using CoffeeShop.Data;

namespace CoffeeShop.Domain
{
    public class CoffeeCalculator
    {
        public OrderCalculator OrderCalculator { get; set; }
        public PriceList PriceList = new PriceList();
        public CoffeeCalculator() {
            OrderCalculator = new OrderCalculator();
        }
        public decimal CalculateCoffeePrice(Coffee orderedCoffee)
        {
            decimal AddPrice;
            switch (orderedCoffee.CoffeeName)
            {
                case CoffeeName.Espresso:
                    AddPrice = PriceList.EspressoPrice;
                break;
                case CoffeeName.Cappuccino:
                    AddPrice = PriceList.CappuccinoPrice;
                break;
                case CoffeeName.LatteMacchiato:
                    AddPrice = PriceList.LatteMacchiato;
                break;
                default:
                    AddPrice = 0;
                break;
            }
            orderedCoffee.IncrementCoffeePrice(AddPrice);

            return OrderCalculator.CalculateTotalPrice(AddPrice);
        }

        public decimal CalculateCoffeeType(Coffee orderedCoffee)
        {
            if (CoffeeType.Large == orderedCoffee.CoffeeType) {
                orderedCoffee.IncrementCoffeePrice(0.7m);
                return OrderCalculator.CalculateTotalPrice(0.7m);
            }
            return OrderCalculator.CalculateTotalPrice(0);
        }
    }
}
