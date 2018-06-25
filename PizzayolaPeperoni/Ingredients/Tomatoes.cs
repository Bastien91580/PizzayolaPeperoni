using System;
namespace PizzayolaPeperoni
{
    public class Tomatoes : IIngredients
    {
        double price = 2;

        protected double GetPrice()
        {
            return price;
        }
    }
}
