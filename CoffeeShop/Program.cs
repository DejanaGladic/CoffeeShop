using CoffeeShop.Domain;

Coffee orderedCoffee = new Coffee();
CoffeeOrder Order = new CoffeeOrder(orderedCoffee);
Order.ChooseCoffee();
Order.ChooseCoffeeType();
Order.ChooseToppings();


Console.WriteLine("Coffee name: {0}, Coffee type: {1}, Coffee price: {2}, Order price: {3}", 
    orderedCoffee.CoffeeName, orderedCoffee.CoffeeType, orderedCoffee.Price, Order.TotalOrderPrice);


