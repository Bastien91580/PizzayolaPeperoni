using System;
namespace PizzayolaPeperoni
{
    public class CBpayment : IPaymentMethod
    {
        public int Pay(double price)
        {
            // Appel du service banquaire
            // retour de valeur pour example
            return 0;
        }
    }
}
