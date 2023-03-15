
using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class Order: IOrder
    {
        private Coffee orderedCoffee { get; set; }
        private Calculator calculator { get; set; }

        public Order(Coffee orderedCoffee)
        {
            this.orderedCoffee = orderedCoffee;
            calculator = new Calculator();
        }
        public void chooseCoffee()
        {
            int PickedCoffee;
            Console.WriteLine("Pick the coffee - choose the number");

            foreach (var value in Enum.GetValues(typeof(CoffeeName)))
            {
                Console.WriteLine("{0}. {1}", (int)value, value.ToString());
            }

            PickedCoffee = Int32.Parse(Console.ReadLine());
            orderedCoffee.CoffeeName = (CoffeeName)PickedCoffee;
            calculator.calculateCoffeePrice(orderedCoffee);
        }

        public void chooseCoffeeType()
        {
            int PickedCoffeeType;
            Console.WriteLine("Pick the coffee type");

            foreach (var value in Enum.GetValues(typeof(CoffeeType)))
            {
                Console.WriteLine("{0}. {1}", (int)value, value.ToString());
            }

            PickedCoffeeType = Int32.Parse(Console.ReadLine());
            orderedCoffee.CoffeeType = (CoffeeType)PickedCoffeeType;
            calculator.calculateCoffeeType(orderedCoffee);
        }
    }
}
