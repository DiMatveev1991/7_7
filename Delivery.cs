using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Delivery
    {
        public string address;
        public string deliveryDate;
        /*
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        */
        /*
        public string DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }
        */
        public Delivery(string address, string deliveryDate)
        {
            this.address = address;
            this.deliveryDate = deliveryDate;
        }
        public abstract void PrintDeliveryInfo();
    }
}
