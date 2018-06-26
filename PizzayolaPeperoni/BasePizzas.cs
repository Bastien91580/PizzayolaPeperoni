using System;
using System.Collections.Generic;
using PizzayolaPeperoni.Ingredients;

namespace PizzayolaPeperoni
{
    public class BasePizzas : IPizza
    {
        String Name;

        BasePizzas(int choise){
            switch(choise){
                case 1:
                    this.Name = "Reine";
                    this.ingredients.Add(new TomatoSauce());
                    this.ingredients.Add(new Ham());
                    this.ingredients.Add(new Cheese());
                    this.ingredients.Add(new Mushrooms());
                    this.price = 12;
                    break;

                case 2:
                    this.Name = "Fermier";
                    this.ingredients.Add(new TomatoSauce());
                    this.ingredients.Add(new Chicken());
                    this.ingredients.Add(new Cheese());
                    this.ingredients.Add(new Mushrooms());
                    this.price = 14;
                    break;

                case 3:
                    this.Name = "Blanche";
                    this.ingredients.Add(new TomatoSauce());
                    this.ingredients.Add(new Ham());
                    this.ingredients.Add(new Cheese());
                    this.price = 15;
                    break;
            }

        }
    }
}
