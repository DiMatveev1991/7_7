using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class HomeDelivery : Delivery
    {
        public string courier;
        public HomeDelivery(string address, string deliveryDate) : base(address, deliveryDate)
        {
            courier = "Александр";
        }
        /*
        public string Courier
        {
            get { return courier; }
            set { courier = value; }
        }
        */
        public override void PrintDeliveryInfo()
        {
            Console.WriteLine("Куръер {0} привезёт ваш заказ {1}\nПо адресу {2}", courier, deliveryDate, address);
        }
    }
}
