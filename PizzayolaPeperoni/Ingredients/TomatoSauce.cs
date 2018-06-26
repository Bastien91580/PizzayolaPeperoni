using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class TomatoSauce : IIngredients
    {
        double price = 1;

        public double GetPrice()
        {
            return price;
        }
    }
}
