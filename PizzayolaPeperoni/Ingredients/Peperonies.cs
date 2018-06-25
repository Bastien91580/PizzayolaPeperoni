using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Peperonies : IIngredients
    {
        double price = 2;

        protected double GetPrice()
        {
            return price;
        }
    }
}
