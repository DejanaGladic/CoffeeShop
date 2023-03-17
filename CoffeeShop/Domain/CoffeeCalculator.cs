
using CoffeeShop.Data;
using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class CoffeeCalculator
    {
        public ICalculator _calculator { get; set; }
        public CoffeeCalculator(ICalculator calculator) {
            _calculator = calculator;
        }
        public void CalculateCoffeePrice(ICoffee orderedCoffee)
        {
            decimal addPrice;
            switch (orderedCoffee.CoffeeName)
            {
                case CoffeeName.Espresso:
                    addPrice = PriceList.espressoPrice;
                break;
                case CoffeeName.Cappuccino:
                    addPrice = PriceList.cappuccinoPrice;
                break;
                case CoffeeName.LatteMacchiato:
                    addPrice = PriceList.latteMacchiato;
                break;
                default:
                    addPrice = 0;
                break;
            }
            orderedCoffee.Price = _calculator.CalculateTotalPrice(addPrice);
        }

        public void CalculateCoffeeType(ICoffee orderedCoffee)
        {
            if (CoffeeType.Large == orderedCoffee.CoffeeType) {
                orderedCoffee.Price = _calculator.CalculateTotalPrice(0.7m);
            }
        }

        public void CalculateToppings(ICoffee orderedCoffee)
        {
            decimal addPrice = 0;
            foreach (string topping in orderedCoffee.Toppings)
            {
                switch (topping)
                {
                    case "milk":
                        addPrice += PriceList.milk;
                        break;
                    case "cinnamon":
                        addPrice += PriceList.cinnamon;
                        break;
                    case "brownsugar":
                        addPrice += PriceList.brownSugar;
                        break;
                    default:
                        addPrice = 0;
                        break;
                }
            }
            orderedCoffee.Price = _calculator.CalculateTotalPrice(addPrice);
        }

        public void CalculateServiceType(ICoffee orderedCoffee)
        {
            switch (orderedCoffee.ServiceType)
            {
                case "couponcode":
                    orderedCoffee.Price = _calculator.CalculateDiscount(PriceList.discount);
                    break;
                case "takeaway":
                    if (orderedCoffee.Price < PriceList.totalPriceBound)
                    {
                        orderedCoffee.Price = _calculator.CalculateIncrease(PriceList.increase);
                    }                   
                    break;
                default:
                    break;
            }
        }
    }
}
