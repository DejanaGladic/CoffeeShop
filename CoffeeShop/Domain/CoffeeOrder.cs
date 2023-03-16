using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class CoffeeOrder : Order, ICoffeeOrder
    {
        public Coffee orderedCoffee { get; set; }
        public List<string> Toppings { get; set; }
        CoffeeCalculator Calculator { get; set; }   

        public CoffeeOrder(Coffee orderedCoffee)
        {
            this.orderedCoffee = orderedCoffee;
            Calculator = new CoffeeCalculator();
            Toppings = new List<string>();  
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
            Calculator.CalculateCoffeePrice(orderedCoffee);
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
            Calculator.CalculateCoffeeType(orderedCoffee);
        }

        public void ChooseToppings()
        {
            Console.WriteLine("Insert the toppings: Milk, Cinnamon, BrownSugar");
            Console.WriteLine("Stop for finish insertion");
            string UserInsert = Console.ReadLine();
            while (!UserInsert.Equals("stop"))
            {
                Toppings.Add(UserInsert);
                UserInsert = Console.ReadLine();
            }
            orderedCoffee.Toppings = Toppings;
            Calculator.CalculateToppings(orderedCoffee);
        }

        internal void ChooseServiceType()
        {
            Console.WriteLine("Insert the service type: in-house, coupon code or take away");
            string UserInsert = Console.ReadLine();
            orderedCoffee.ServiceType = UserInsert;
            Calculator.CalculateServiceType(orderedCoffee);
        }

        public override void PrintTheBill()
        {            
            Console.WriteLine("Coffee name: {0}, Coffee type: {1},Servis type: {2}, Coffee price: {3}",
               orderedCoffee.CoffeeName, orderedCoffee.CoffeeType,
                orderedCoffee.ServiceType, orderedCoffee.Price);
        }
    }
}
