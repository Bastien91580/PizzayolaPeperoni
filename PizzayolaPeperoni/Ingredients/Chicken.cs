﻿using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Chicken : IIngredients
    {
        double price = 2;

        public double GetPrice()
        {
            return price;
        }
    }
}
 