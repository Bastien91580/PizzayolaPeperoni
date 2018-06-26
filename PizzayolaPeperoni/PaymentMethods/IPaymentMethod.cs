using System;
namespace PizzayolaPeperoni
{
    public interface IPaymentMethod
    {
        int Pay(double price);
    }
}
