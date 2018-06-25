using System;
namespace PizzayolaPeperoni
{
    public class Payement
    {
        Order order;
        int isPayed;

        public Payement(Order order)
        {
            this.order = order;
        }

        public int Pay(){
            isPayed = 1;
            return 0;
        }

    }
}
