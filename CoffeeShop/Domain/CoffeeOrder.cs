using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public class CoffeeOrder : ICoffeeOrder
    {
        public ICoffee _orderedCoffee;
        CoffeeCalculator _coffeeCalculator;
        public CoffeeOrder(ICoffee orderedCoffee, CoffeeCalculator coffeeCalculator)
        {
            _orderedCoffee = orderedCoffee;
            _coffeeCalculator = coffeeCalculator;
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
            _orderedCoffee.CoffeeName = (CoffeeName)PickedCoffee;
            _coffeeCalculator.CalculateCoffeePrice(_orderedCoffee);
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
            _orderedCoffee.CoffeeType = (CoffeeType)PickedCoffeeType;
            _coffeeCalculator.CalculateCoffeeType(_orderedCoffee);
        }

        public void ChooseToppings()
        {
            IEnumerable<string> toppings = new List<string>();
            Console.WriteLine("Insert the toppings: Milk, Cinnamon, Brown Sugar");
            Console.WriteLine("Stop for finish insertion");
            string userInsert = Console.ReadLine().Trim().Replace(" ", "").ToLower();
            while (!userInsert.Equals("stop"))
            {
                ((List<string>)toppings).Add(userInsert);
                userInsert = Console.ReadLine().Trim().Replace(" ", "").ToLower();
            }
            _orderedCoffee.Toppings = toppings;
            _coffeeCalculator.CalculateToppings(_orderedCoffee);
        }

        public void ChooseServiceType()
        {
            Console.WriteLine("Insert the service type: in-house, coupon code or take away");
            string UserInsert = Console.ReadLine().Trim().Replace(" ", "").ToLower();
            _orderedCoffee.ServiceType = UserInsert;
            _coffeeCalculator.CalculateServiceType(_orderedCoffee);
        }

        public void PrintTheBill()
        {            
            Console.WriteLine("Coffee name: {0}, Coffee type: {1},Servis type: {2}, Coffee price: {3}",
               _orderedCoffee.CoffeeName, _orderedCoffee.CoffeeType,
                _orderedCoffee.ServiceType, _orderedCoffee.Price);
        }
    }
}
