using CoffeeShop.Domain;

Coffee orderedCoffee = new Coffee();
CoffeeOrder Order = new CoffeeOrder(orderedCoffee);
Order.ChooseCoffee();
Order.ChooseCoffeeType();
Order.ChooseToppings();
Order.ChooseServiceType();
Order.PrintTheBill();



