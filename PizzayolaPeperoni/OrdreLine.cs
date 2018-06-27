using System;
namespace PizzayolaPeperoni
{
    public class OrdreLine
    {
        public IPizza pizza { get; set; }
        public int quantity  { get; set; } 

        public OrdreLine(IPizza pizza, int quantity){
            this.pizza = pizza;
            this.quantity = quantity;
        }
    }
}
