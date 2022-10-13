using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceApplication
{
    public enum OrderStatus{Default,Booked,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=1001;
        public string OrderId { get; }
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public double TotalPrice { get; set; }  
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public OrderStatus OrderStatus { get; set; }


        public OrderDetails(string customerId,string productId,double totalPrice,DateTime purchaseDate,int quantity,OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            CustomerId=customerId;
            ProductId=productId;
            TotalPrice=totalPrice;
            PurchaseDate=purchaseDate;
            Quantity=quantity;
            OrderStatus=orderStatus;
            
        }
    }
}