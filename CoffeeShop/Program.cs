using CoffeeShop.Domain;

Coffee orderedCoffee = new Coffee();
CoffeeOrder Order = new CoffeeOrder(orderedCoffee);
Order.ChooseCoffee();
Order.ChooseCoffeeType();
Order.ChooseToppings();
Order.ChooseServiceType();


Console.WriteLine("Coffee name: {0}, Coffee type: {1},Servis type: {2}, Coffee price: {3}", 
    orderedCoffee.CoffeeName, orderedCoffee.CoffeeType, orderedCoffee.ServiceType,orderedCoffee.Price);


