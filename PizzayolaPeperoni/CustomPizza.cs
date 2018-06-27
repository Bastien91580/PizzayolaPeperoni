using System;
using System.Collections.Generic;
using PizzayolaPeperoni.Ingredients;

namespace PizzayolaPeperoni
{
    public class CustomPizza : IPizza
    {
        public void AddIngredient(IIngredients ingredient)
        {
            this.ingredients.Add(ingredient);
        }


        public new double GetPrice()
        {
            this.price = 5;
            IIterator iterator = new ConcreteIterator(ingredients);
            double ingredientPrice = iterator.GetFirstItem();
            while (iterator.IsDone() == false)
            {
                ingredientPrice += iterator.NextItem();
            }

            this.price += ingredientPrice;
            return this.price;
        }

    }
}
