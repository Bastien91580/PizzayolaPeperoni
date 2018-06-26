using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Tomatoes : IIngredients
    {
        double price = 2;

        public double GetPrice()
        {
            return price;
        }
    }
}
