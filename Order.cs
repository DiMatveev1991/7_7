using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Order<TDelivery, TProduct>
         where TDelivery : Delivery
         where TProduct : Product
    {

        public void MakeOrder()
        {
            string stringnum;
            int intnum;
            Console.WriteLine("Добро пожаловать в магазин абсурда и бреда");
            do
            {
                Console.WriteLine("Выберите категорию: \n1 Спортовары\n2 Мыльные принадлежности\n Введите: 1 или 2");
                stringnum = Console.ReadLine();

            } while (TestforRead.InputChek2(stringnum, out intnum));
            // int num;
            if (intnum == 1)
            {
                do
                {
                    Console.WriteLine("Выберите категорию: \n1 Велосипед\n2 Забудте про велосипед купите скокалку\n Введите: 1 или 2");
                    stringnum = Console.ReadLine();

                } while (TestforRead.InputChek2(stringnum, out intnum));
                if (intnum == 1)
                {   
                    Product product1 = new("Велосипед", "Артикул");
                    do
                    {
                        Console.WriteLine("Выберите способ получения:");
                        Console.WriteLine("1 Доставка курьером \n2 Доставка в точку самовывоза" +
                            "\n3 Доставка в магазин");
                        stringnum = Console.ReadLine();
                    } while (TestforRead.InputChek3(stringnum, out intnum));
                    if (intnum == 1)
                    {
                        Console.WriteLine("Введите адрес доставки");
                        string address = Console.ReadLine();
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        HomeDelivery delivery = new(address, deliveryDate);
                        product1.PrintProductIonInfo();
                        delivery.PrintDeliveryInfo();
                    }
                    else if (intnum == 2)
                    {
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        string pickPointAddress = PickPointDelivery.PickPointAddress;
                        PickPointDelivery pickPointDelivery = new(pickPointAddress, deliveryDate);
                        product1.PrintProductIonInfo();
                        pickPointDelivery.PrintDeliveryInfo();
                    }
                    else if (intnum == 3)
                    {
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        string shopAddress = ShopDelivery.ShopAddress;
                        ShopDelivery shopDelivery = new(shopAddress, deliveryDate);
                        product1.PrintProductIonInfo();
                        shopDelivery.PrintDeliveryInfo();
                    }
                }
                else
                {
                    Product product1 = new("Скокалка", "Артикул");
                    do
                    {
                        Console.WriteLine("Выберите способ получения:");
                        Console.WriteLine("1 Доставка курьером \n2 Доставка в точку самовывоза" +
                            "\n3 Доставка в магазин");
                        stringnum = Console.ReadLine();
                    } while (TestforRead.InputChek3(stringnum, out intnum));
                    if (intnum == 1)
                    {
                        Console.WriteLine("Введите адрес доставки");
                        string address = Console.ReadLine();
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        HomeDelivery delivery = new(address, deliveryDate);
                        product1.PrintProductIonInfo();
                        delivery.PrintDeliveryInfo();
                    }
                    else if (intnum == 2)
                    {
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        string pickPointAddress = PickPointDelivery.PickPointAddress;
                        PickPointDelivery pickPointDelivery = new(pickPointAddress, deliveryDate);
                        product1.PrintProductIonInfo();
                        pickPointDelivery.PrintDeliveryInfo();
                    }
                    else if (intnum == 3)
                    {
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        string shopAddress = ShopDelivery.ShopAddress;
                        ShopDelivery shopDelivery = new(shopAddress, deliveryDate);
                        product1.PrintProductIonInfo();
                        shopDelivery.PrintDeliveryInfo();
                    }
                }
            }
            else if (intnum == 2)
            {
                do
                {
                    Console.WriteLine("Выберите категорию: \n1 Мыло\n2 Веревка\n Введите: 1 или 2");
                    stringnum = Console.ReadLine();

                } while (TestforRead.InputChek2(stringnum, out intnum));
                if (intnum == 1)
                {   //поидеи можно было реализовать счётчик заказов и выдавать номер склеивая счётчик с артикулом товара
                    //но делать я этого не стал, много времени потратил на понимание что и как.... не до конца всё осознал)
                    //хочу уже перейти к новому модулю наконец...
                    Product product1 = new("Мыло", "Артикул");
                    do
                    {
                        Console.WriteLine("Выберите способ получения:");
                        Console.WriteLine("1 Доставка курьером \n2 Доставка в точку самовывоза" +
                            "\n3 Доставка в магазин");
                        stringnum = Console.ReadLine();
                    } while (TestforRead.InputChek3(stringnum, out intnum));
                    if (intnum == 1)
                    {
                        Console.WriteLine("Введите адрес доставки");
                        string address = Console.ReadLine();
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        HomeDelivery delivery = new(address, deliveryDate);
                        product1.PrintProductIonInfo();
                        delivery.PrintDeliveryInfo();
                    }
                    else if (intnum == 2)
                    {
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        string pickPointAddress = PickPointDelivery.PickPointAddress;
                        PickPointDelivery pickPointDelivery = new(pickPointAddress, deliveryDate);
                        product1.PrintProductIonInfo();
                        pickPointDelivery.PrintDeliveryInfo();
                    }
                    else if (intnum == 3)
                    {
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        string shopAddress = ShopDelivery.ShopAddress;
                        ShopDelivery shopDelivery = new(shopAddress, deliveryDate);
                        product1.PrintProductIonInfo();
                        shopDelivery.PrintDeliveryInfo();
                    }
                }
                else
                {
                    Product product1 = new("Веревка", "Артикул");
                    do
                    {
                        Console.WriteLine("Выберите способ получения:");
                        Console.WriteLine("1 Доставка курьером \n2 Доставка в точку самовывоза" +
                            "\n3 Доставка в магазин");
                        stringnum = Console.ReadLine();
                    } while (TestforRead.InputChek3(stringnum, out intnum));
                    if (intnum == 1)
                    {
                        Console.WriteLine("Введите адрес доставки");
                        string address = Console.ReadLine();
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        HomeDelivery delivery = new(address, deliveryDate);
                        product1.PrintProductIonInfo();
                        delivery.PrintDeliveryInfo();
                    }
                    else if (intnum == 2)
                    {
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        string pickPointAddress = PickPointDelivery.PickPointAddress;
                        PickPointDelivery pickPointDelivery = new(pickPointAddress, deliveryDate);
                        product1.PrintProductIonInfo();
                        pickPointDelivery.PrintDeliveryInfo();
                    }
                    else if (intnum == 3)
                    {
                        Console.WriteLine("Введите желаемую дату доставки:");
                        string deliveryDate = Console.ReadLine();
                        string shopAddress = ShopDelivery.ShopAddress;
                        ShopDelivery shopDelivery = new(shopAddress, deliveryDate);
                        product1.PrintProductIonInfo();
                        shopDelivery.PrintDeliveryInfo();
                    }
                }
            }
        }
    }
}
