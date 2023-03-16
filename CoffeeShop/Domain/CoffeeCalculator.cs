
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
        public void CalculateCoffeePrice(Coffee orderedCoffee)
        {
            decimal AddPrice = 0;
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
            orderedCoffee.Price = OrderCalculator.CalculateTotalPrice(AddPrice);
        }

        public void CalculateCoffeeType(Coffee orderedCoffee)
        {
            if (CoffeeType.Large == orderedCoffee.CoffeeType) {
                orderedCoffee.Price = OrderCalculator.CalculateTotalPrice(0.7m);
            }
        }

        public void CalculateToppings(Coffee orderedCoffee)
        {
            decimal AddPrice = 0;
            foreach (string Topping in orderedCoffee.Toppings)
            {
                switch (Topping)
                {
                    case "Milk":
                        AddPrice += PriceList.Milk;
                        break;
                    case "Cinnamon":
                        AddPrice += PriceList.Cinnamon;
                        break;
                    case "BrownSugar":
                        AddPrice += PriceList.BrownSugar;
                        break;
                    default:
                        AddPrice = 0;
                        break;
                }
            }
            orderedCoffee.Price = OrderCalculator.CalculateTotalPrice(AddPrice);
        }

        public void CalculateServiceType(Coffee orderedCoffee)
        {
            switch (orderedCoffee.ServiceType)
            {
                case "coupon code":
                    orderedCoffee.Price = OrderCalculator.CalculateDiscount(5);
                    break;
                case "take away":
                    if (orderedCoffee.Price < 7m)
                    {
                        orderedCoffee.Price = OrderCalculator.CalculateIncrease(2);
                    }                   
                    break;
                default:
                    break;
            }
        }
    }
}
