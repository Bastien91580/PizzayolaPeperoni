﻿using System;
namespace PizzayolaPeperoni.States
{
    public class Available : IState
    {
        public int AddPizza(IPizza pizza, int quantity)
        {
            return 2;
        }

        public int PayOrder(double price, int methode)
        {
            return 2;
        }

        public int TakeOf()
        {
            return 0;
        }
    }
}
