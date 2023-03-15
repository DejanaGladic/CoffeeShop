using CoffeeShop.Domain;

Coffee orderedCoffee = new Coffee();
Order order = new Order(orderedCoffee);
order.chooseCoffee();
order.chooseCoffeeType();

Console.WriteLine("Coffee name: {0}, Coffee type: {1}, Coffee type: {2}", 
    orderedCoffee.CoffeeName, orderedCoffee.CoffeeType, orderedCoffee.Price);


