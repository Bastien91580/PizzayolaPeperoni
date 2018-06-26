using System;
namespace PizzayolaPeperoni
{
    public class Payment
    {
        public int Pay(double price, int method)
        {
            IPaymentMethod payment;
            if(method == 1){
                payment = new CBpayment();
                return payment.Pay(price);
            }

            if(method == 2){
                payment = new PaypalPayment();
                return payment.Pay(price);
            }

            return 3;
        }
    }
}
