﻿using System;
namespace PizzayolaPeperoni.States
{
    public class End : IState
    {
        public int AddPizza(IPizza pizza, int quantity)
        {
            return 2;
        }

        public int PayOrder(double price, int methode)
        {
            return 4;
        }

        public int TakeOf()
        {
            return 2;
        }
    }
}
