using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Peperonies : IIngredients
    {
        double price = 2;

        public double GetPrice()
        {
            return price;
        }
    }
}
