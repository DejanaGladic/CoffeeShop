using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class CoffeeOrder : ICoffeeOrder
    {
        public Coffee orderedCoffee { get; set; }
        public CoffeeCalculator Calculator { get; set; }

        public decimal TotalOrderPrice { get; set; }

        public CoffeeOrder(Coffee orderedCoffee)
        {
            this.orderedCoffee = orderedCoffee;
            Calculator = new CoffeeCalculator();
        }
        public void ChooseCoffee()
        {
            int PickedCoffee;
            Console.WriteLine("Pick the coffee - choose the number");

            foreach (var value in Enum.GetValues(typeof(CoffeeName)))
            {
                Console.WriteLine("{0}. {1}", (int)value, value.ToString());
            }

            PickedCoffee = int.Parse(Console.ReadLine());
            orderedCoffee.CoffeeName = (CoffeeName)PickedCoffee;
            TotalOrderPrice = Calculator.CalculateCoffeePrice(orderedCoffee);
        }

        public void ChooseCoffeeType()
        {
            int PickedCoffeeType;
            Console.WriteLine("Pick the coffee type");

            foreach (var value in Enum.GetValues(typeof(CoffeeType)))
            {
                Console.WriteLine("{0}. {1}", (int)value, value.ToString());
            }

            PickedCoffeeType = int.Parse(Console.ReadLine());
            orderedCoffee.CoffeeType = (CoffeeType)PickedCoffeeType;
            TotalOrderPrice = Calculator.CalculateCoffeeType(orderedCoffee);
        }
    }
}
