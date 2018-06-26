using System;
namespace PizzayolaPeperoni
{
    public class OrdreLine
    {
        IPizza pizza { get; set; }
        int quantity  { get; set; } 

        public OrdreLine(IPizza pizza, int quantity){
            this.pizza = pizza;
            this.quantity = quantity;
        }
    }
}
