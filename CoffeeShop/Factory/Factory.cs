using CoffeeShop.Domain;
using CoffeeShop.Interfaces;

namespace CoffeeShop.Factory
{
    public static class Factory
    {
        public static ICoffee CreateCoffee() {
            return new Coffee();
        }
        public static ICalculator CreateCalculator()
        {
            return new OrderCalculator();
        }
        public static CoffeeCalculator CreateCoffeeCalculator()
        {
            return new CoffeeCalculator(CreateCalculator());
        }
        public static ICoffeeOrder CreateCoffeeOrder()
        {
            return new CoffeeOrder(CreateCoffee(), CreateCoffeeCalculator());
        }
    }
}
