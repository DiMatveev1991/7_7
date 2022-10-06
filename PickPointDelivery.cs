using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class PickPointDelivery : Delivery
    {
        static readonly int storageTime = 48;
        static readonly string pickPointAddress = "г. Забулдыгино дом 5 ТЦ Ромашка";
        public PickPointDelivery(string address, string deliveryDate) : base(address, deliveryDate)
        {

        }
        public static string PickPointAddress
        {
            get
            {
                return pickPointAddress;
            }
        }
        public override void PrintDeliveryInfo()
        {
            Console.WriteLine("Ваш заказ прибудет в точку {0}\nПо адресу:{1}", deliveryDate, pickPointAddress);
            Console.WriteLine("Время хранения заказа {0} ч.", storageTime);
        }
    }
   
}