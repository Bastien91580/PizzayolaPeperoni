using System;
using System.Collections.Generic;
using PizzayolaPeperoni.Ingredients;

namespace PizzayolaPeperoni
{
    public class CustomPizza : IPizza
    {
        public void AddIngredient(IIngredients ingredient){
            this.ingredients.Add(ingredient);
            this.price += ingredient.GetPrice();
        }

    }
}
