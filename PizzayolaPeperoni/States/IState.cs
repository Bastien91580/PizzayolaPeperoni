using System;
namespace PizzayolaPeperoni
{
    public interface IState
    {
        int PayOrder(double price, int methode);
        int AddPizza(IPizza pizza, int quantity);
    }
}
