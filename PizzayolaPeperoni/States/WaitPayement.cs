using System;
namespace PizzayolaPeperoni.States
{
    public class WaitPayement : IState
    {
        public int AddPizza(IPizza pizza, int quantity)
        {
            return 0;
        }

        public int PayOrder(double price, int method)
        {
            Payment payment = new Payment();
            int result = payment.Pay(price, method);
            return result;
        }

        public int TakeOf()
        {
            return 1;
        }

    }
}
