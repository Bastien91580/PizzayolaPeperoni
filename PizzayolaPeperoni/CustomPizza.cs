using System;
using System.Collections.Generic;
using PizzayolaPeperoni.Ingredients;

namespace PizzayolaPeperoni
{
    public class CustomPizza : IPizza
    {
        public void AddIngredient(IIngredients ingredient){
            this.ingredients.Add(ingredient);
        }

        public double GetPrice(){
            IIterator iterator = new ConcreteIterator(ingredients);
            double ingredientPrice = iterator.GetFirstItem();
            while(iterator.IsDone() == false){
                ingredientPrice += iterator.NextItem();
            }

            this.price += ingredientPrice;
            return this.price;
        }

    }
}
