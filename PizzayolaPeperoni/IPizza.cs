using System;
using System.Collections.Generic;
using PizzayolaPeperoni.Ingredients;

namespace PizzayolaPeperoni
{
    public abstract class IPizza
    {
        protected List<IIngredients> ingredients;
        protected double price = 5;
    }
}
