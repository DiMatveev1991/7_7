using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class ShopDelivery : Delivery
    {
        static readonly int storageTime = 72;
        static readonly string shopAddress = "г.Забулдыгино ул. Старого пепла дом 7 ТЦ Варяг";
        public ShopDelivery(string address, string deliveryDate) : base(address, deliveryDate) { }
        /*
        public static int StorageTime
        {
            get { return storageTime; }
        }
        */
        public static string ShopAddress
        {
            get
            {
                return shopAddress;
            }
        }
        public override void PrintDeliveryInfo()
        {
            Console.WriteLine("Ваш заказ прибудет в магазин {0}\nПо адресу {1}", deliveryDate, address);
            Console.WriteLine("Время хранения заказа {0} ч.", storageTime);
        }
    }
    /// <summary>
    /// Класс заказ с основным методом
    /// </summary>
    /// <typeparam name="TDelivery"></typeparam>
    /// <typeparam name="TProduct"></typeparam>
}
