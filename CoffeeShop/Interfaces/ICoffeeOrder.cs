namespace CoffeeShop.Interfaces
{
    public interface ICoffeeOrder: IOrder
    {
        public void ChooseCoffee();
        public void ChooseCoffeeType();
        public void ChooseToppings();
        public void ChooseServiceType();
    }
}
