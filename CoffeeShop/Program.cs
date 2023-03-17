using CoffeeShop.Factory;
using CoffeeShop.Interfaces;


ICoffeeOrder order = Factory.CreateCoffeeOrder();
order.ChooseCoffee();
order.ChooseCoffeeType();
order.ChooseToppings();
order.ChooseServiceType();
order.PrintTheBill();



