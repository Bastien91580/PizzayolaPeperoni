using System;
using System.Collections.Generic;

namespace PizzayolaPeperoni
{
    public abstract class IPizza
    {
        protected List<IIngredients> ingredients;
        protected double price = 0;

        protected void AddIngredient (IIngredients ingredients){
            this.ingredients.Add(ingredients);
        }
        /*
        protected double GetPrice(){
            price = 0;
            foreach(var el in ingredients){
                price += IIngredients.GetPrice(el);
            }
        }*/
    }
}
