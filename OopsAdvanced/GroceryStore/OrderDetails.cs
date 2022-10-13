using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderId { get;  }
        public string BookingId { get; set; }
        public string ProductId { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceofOrder { get; set; }

        public OrderDetails(string bookingId,string productId,int purchaseCount,double priceofOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            ProductId=productId;
            PurchaseCount=purchaseCount;
            PriceofOrder=priceofOrder;
        }

        public OrderDetails(string Data)
        {
            string[] value=Data.Split(',');
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0];
            BookingId=value[1];
            PurchaseCount=int.Parse(value[2]);
            PriceofOrder=double.Parse(value[3]);
        }

        public void ShowOrder()
        {
            System.Console.WriteLine("Your Order Id is: "+OrderId);
            System.Console.WriteLine("Your booking Id is: "+BookingId);
            System.Console.WriteLine("Your Product Id is: "+ProductId);
            System.Console.WriteLine("Your Purchase Count is: "+PurchaseCount);
            System.Console.WriteLine("The total price is: "+PriceofOrder);
            System.Console.WriteLine(" ");
        }
    }
}