using System;
namespace PizzayolaPeperoni
{
    public interface IIterator
    {
        double GetFirstItem();
        double NextItem();
        bool IsDone();
    }
}
