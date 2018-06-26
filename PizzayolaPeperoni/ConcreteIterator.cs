using System;
using System.Collections.Generic;
using System.Linq;
using PizzayolaPeperoni.Ingredients;

namespace PizzayolaPeperoni
{
    public class ConcreteIterator : IIterator
    {
        List<IIngredients> listIngredient { get; set; }
        int index = 0;

        public ConcreteIterator(List<IIngredients> list)
        {
            this.listIngredient = list;
        }

        public double GetFirstItem()
        {
            return listIngredient.First().GetPrice();
        }

        public bool IsDone()
        {
            if (index == listIngredient.Count() - 1)
            {
                return true;
            }
            return false;
        }

        public double NextItem()
        {
            index++;
            if (IsDone() == false)
            {
                return listIngredient[index].GetPrice();
            }
            else
            {
                return -1;
            }
        }
    }
}