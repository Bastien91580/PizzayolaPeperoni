using System;
using System.Collections.Generic;
using PizzayolaPeperoni.States;

namespace PizzayolaPeperoni
{
    public class Order
    {
        List<OrdreLine> listOfPizzas;
        double price;
        IState state;
        User user;

        public Order(User user){
            this.user = user;
        }

        public void PayOrder(int method){
            int result = state.PayOrder(this.price, method);
            switch (result){
                case 0:
                    Console.WriteLine("Payement Accepté, envoie de votre commande ...");
                    this.state = new Received();
                    break;

                case 1:
                    Console.WriteLine("Fond issufisant pour payer votre commande !");
                    break;

                case 2:
                    Console.WriteLine("Commande deja payée");
                    break;

                case 3:
                    Console.WriteLine("Erreur lors de la selection de la methode");
                    break;
            }

        }

        public void AddPizza(IPizza pizza, int quantity){
            int result = state.AddPizza(pizza, quantity);
            switch (result){
                case 0:
                    OrdreLine orderLine = new OrdreLine(pizza, quantity);
                    listOfPizzas.Add(orderLine);
                    Console.WriteLine("Pizza(s) ajoutée(s) à votre commande");
                    break;

                case 2:
                    Console.WriteLine("Vous ne pouvez ajouter de pizza à cette etape de la commande");
                    break;
            }
        }
    }
}
