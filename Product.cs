using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Product
    {
        public string name;
        Description description;
        public Product(string name, string description)
        {
            this.description = new Description(description);
            this.name = name;
        }
        public void PrintProductIonInfo()
        {
            Console.WriteLine("Ваш товар : {0} ", name);
        }
    }
}
