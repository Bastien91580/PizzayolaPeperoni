using System;
using PizzayolaPeperoni.Ingredients;

namespace PizzayolaPeperoni
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Voici Jean-Jack
            //  
            //  \,`/ /
            // _)..  `_
            //( __  -\
            //    '`.
            //   ( \>_-_,
            //   _||_ ~-/
            //
            // Jean-Jack veut acheter un pizza
            User user = new User("Jean");
            Console.WriteLine("Bonjour Jean !");

            // Creation de la commande de Jean
            Order order = new Order(user);
            Console.WriteLine("Debut de votre commande");

            // Jean-Jack veut ajouter un Reine
            BasePizzas reine = new BasePizzas(1);
            order.AddPizza(reine, 1);

            // Jean-Jack veut se faire un pizza perso
            CustomPizza custom = new CustomPizza();
            custom.AddIngredient(new TomatoSauce());
            custom.AddIngredient(new Chicken());
            custom.AddIngredient(new Cheese());
            custom.AddIngredient(new Ham());
            custom.AddIngredient(new CreamSauce());
            Console.WriteLine("Prix Pizza perso : " + custom.GetPrice() + "€");
            order.AddPizza(custom, 1);

            // Affichage du prix de la commande
            Console.WriteLine("Votre commande est à : " + order.GetPrice() + "€");

            // Jean-Jack veut payer avec Paypal mais il n'a pas assez d'argent
            order.PayOrder(2);

            // Jean-Jack decide de payer avec sa carte bleu
            order.PayOrder(1);

            // Jean-Jack essaye de Hacker le systeme et d'ajouter un pizza apres avoir payer mais bien sur ça foire
            BasePizzas blanche = new BasePizzas(3);
            order.AddPizza(blanche, 1);

            // Jean-Jack ayant Alzheimer (Oui j'ai cherché sur Internet) essaye de payer une deuxieme fois
            order.PayOrder(1);

            // Puis le Pizza Yolo qui fait les choses comme il veut
            order.OrderAccepted();

            // Comme Jean-Jack est un peu lent il essaie encore de payer
            order.PayOrder(1);

            // Comme les mecs sont rapide des quelle sort du four il la mette en boite et Op sur le comptoire
            order.ItsCooked();
            order.ItsPacked();

            // Et la Jean-Jack va chercher sa pizza
            order.TakeOff();

            // Puis il revient 15 min plus tard histoire de grater un pizza mais non il y en a plus
            order.TakeOff();


        }
    }
}
