using System;
namespace PizzayolaPeperoni
{
    public class PaypalPayment : IPaymentMethod
    {
        public int Pay(double price)
        {
            // Appel du service de Payement Paypal
            // retour de valeur pour example
            return 1;
        }
    }
}
