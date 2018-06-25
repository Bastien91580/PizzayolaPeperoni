using System;

namespace PizzayolaPeperoni
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while(!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)){
            }
            Console.WriteLine("Good Bye !");
        }
    }
}
