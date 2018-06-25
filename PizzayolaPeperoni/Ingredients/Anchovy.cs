using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Anchovy : IIngredients
    {
        double price = 2;

        protected double GetPrice(){
            return price;   
        }
    }
}
