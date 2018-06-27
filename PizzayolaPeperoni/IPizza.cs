using System;
using System.Collections.Generic;
using PizzayolaPeperoni.Ingredients;

namespace PizzayolaPeperoni
{
    public abstract class IPizza
    {
        public List<IIngredients> ingredients = new List<IIngredients>();
        public double price = 5;

        public double GetPrice(){
            return this.price;
        }
    }
}
