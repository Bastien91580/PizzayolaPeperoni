using System;
namespace PizzayolaPeperoni
{
    public class Mushrooms : IIngredients
    {
        double price = 2;

        protected double GetPrice()
        {
            return price;
        }
    }
}
