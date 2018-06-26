using System;
namespace PizzayolaPeperoni
{
    public class User
    {
        double money { get; set; }
        String name { get; set; }

        User(double money, String name){
            this.money = money;
            this.name = name;
        }

        public double getMoney(){
            return this.money;
        }
    }
}
