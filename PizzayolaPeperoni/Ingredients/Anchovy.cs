using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Anchovy : IIngredients
    {
        double price = 2;

        public double GetPrice(){
            return price;   
        }


    }
}
