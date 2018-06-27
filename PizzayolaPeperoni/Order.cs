using System;
using System.Collections.Generic;
using PizzayolaPeperoni.States;

namespace PizzayolaPeperoni
{
    public class Order
    {
        List<OrdreLine> listOfPizzas = new List<OrdreLine>();
        double price;
        IState state;
        User user;

        public Order(User user){
            this.state = new WaitPayement();
            this.user = user;
        }

        public void CalculatePrice(){
            this.price = 0;
            foreach(var el in listOfPizzas){
                price += (el.pizza.GetPrice() * el.quantity);
            }
        }

        public double GetPrice(){
            CalculatePrice();
            return this.price;
        }

        public void PayOrder(int method){
            CalculatePrice();
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

                case 4:
                    Console.WriteLine("Commande Terminé");
                    break;
            }

        }

        public void AddPizza(IPizza pizza, int quantity){
            int result = state.AddPizza(pizza, quantity);
            CalculatePrice();
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

        public void TakeOff(){
            int result = state.TakeOf();
            switch (result){
                case 0:
                    Console.WriteLine("Commande retiré, Merci et à Bientot !");
                    this.state = new End();
                    break;

                case 1:
                    Console.WriteLine("Vous ne pouvez retirer votre commande pour le moment");
                    break;

                case 2:
                    Console.WriteLine("Vous avez deja retiré votre commande");
                    break;
            }
        }

        public void OrderAccepted(){
            Console.WriteLine("La commande est Accepté, elle est maintenent en cour de préparation");
            this.state = new InProgress();
        }

        public void ItsCooked(){
            Console.WriteLine("Vos pizza sont cuite, elle devrait etre bientot disponible");
            this.state = new Completed();
        }

        public void ItsPacked(){
            Console.WriteLine("Vos pizza sont diponible au comptoire");
            this.state = new Available();
        }
    }
}
