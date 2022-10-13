using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class OrderDetails
    {
        private static int s_orderId=100;
        public string OrderId { get; set; }
        public string  BookingId { get; set; }
        public string ProductId { get; set; }
        public string  FoodId { get; set; }
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }

        public OrderDetails(string bookingId,string foodId,int purchaseCount,int price)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            //ProductId=productId;
            FoodId=foodId;
            PurchaseCount=purchaseCount;
            PriceOfOrder=price;
        }

        public OrderDetails(string Data)
        {
            string[] value=Data.Split(',');
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0].Remove(0,3);
            BookingId=value[1];
            ProductId=value[2];
            FoodId=value[3];
            PurchaseCount=int.Parse(value[4]);
            PriceOfOrder=int.Parse(value[5]);
        }

        public void ShowOrder()
        {
            System.Console.WriteLine("Your Order Id is: "+OrderId);
            System.Console.WriteLine("Your Booking Id is: "+BookingId);
            System.Console.WriteLine("Your Product Id is: "+ProductId);
            System.Console.WriteLine("Your Food Id is: "+FoodId);
            System.Console.WriteLine("Total purchase is: "+PurchaseCount);
            System.Console.WriteLine("Your Bill Value is: "+PriceOfOrder);
        }

    }
}