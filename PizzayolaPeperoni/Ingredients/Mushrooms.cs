﻿using System;
namespace PizzayolaPeperoni.Ingredients
{
    public class Mushrooms : IIngredients
    {
        double price = 2;

        public double GetPrice()
        {
            return price;
        }
    }
}
