using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public enum OrderStatus{Default,Purchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=2000;
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public string MedicineId { get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(int totalPrice,DateTime orderDate,OrderStatus orderStatus)
        {
            TotalPrice=totalPrice;
            OrderDate=DateTime.Now;
            OrderStatus=orderStatus;

        }

        public OrderDetails(string data)
        {
            string[] value=data.Split(',');
            s_orderId=int.Parse(value[0].Remove(0,3));
            TotalPrice=int.Parse(value[1]);
            OrderDate=DateTime.Parse(value[2]);
            OrderStatus=Enum.Parse<OrderStatus>(value[3]);
        }
    }
}