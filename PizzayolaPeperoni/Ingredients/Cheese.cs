using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Cheese : IIngredients
    {
        double price = 2;

        protected double GetPrice()
        {
            return price;
        }
    }
}
