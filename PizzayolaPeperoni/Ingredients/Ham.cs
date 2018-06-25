using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Ham : IIngredients
    {
        double price = 2;

        protected double GetPrice()
        {
            return price;
        }
    }
}
