using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Order<Delivery, Product> order = new();
            order.MakeOrder();
        }
    }
}
