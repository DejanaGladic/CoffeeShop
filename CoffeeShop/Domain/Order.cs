using CoffeeShop.Interfaces;

namespace CoffeeShop.Domain
{
    public abstract class Order : IView
    {
        public abstract void PrintTheBill();
    }
}
