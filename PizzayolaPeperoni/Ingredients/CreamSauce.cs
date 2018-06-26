using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class CreamSauce : IIngredients
    {
        double price = 1;

        public double GetPrice()
        {
            return price;
        }
    }
}
