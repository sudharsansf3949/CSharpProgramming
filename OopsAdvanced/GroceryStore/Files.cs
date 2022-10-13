using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public class Files
    {
        public static  void Create()
        {
            if(!Directory.Exists("GroceryStore"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("GroceryStore");
            }
            if(!File.Exists("GroceryStore/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("GroceryStore/CustomerDetails.csv");
            }
            if(!File.Exists("GroceryStore/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("GroceryStore/BookingDetails.csv");
            }
            if(!File.Exists("GroceryStore/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("GroceryStore/OrderDetails.csv");
            }
            if(!File.Exists("GroceryStore/ProductDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("GroceryStore/ProductDetails.csv");
            }
        }

        public static void ReadFile()
        {
            string [] customer=File.ReadAllLines("GroceryStore/CustomerDetails.csv");
            foreach(string data in customer)
            {
                CustomerDetails customers=new CustomerDetails(data);
                Operations.customerList.Add(customers);
            }

            string [] booking=File.ReadAllLines("GroceryStore/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails bookings=new BookingDetails(data);
                Operations.bookingsList.Add(bookings);
            }

            string [] order =File.ReadAllLines("GroceryStore/OrderDetails.csv");
            foreach(string data in order)
            {
                OrderDetails orders=new OrderDetails(data);
                Operations.orderList.Add(orders);
            }

            string [] product=File.ReadAllLines("GroceryStore/ProductDetails.csv");
            foreach(string data in product)
            {
               ProductDetails products=new ProductDetails(data);
                Operations.productList.Add(products);
            }
        }

        public static void WriteFile()
        {
            string[] customer=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customer[i]=Operations.customerList[i].CustomerId+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].MobileNumber+","+Operations.customerList[i].DOB+","+Operations.customerList[i].MailId+","+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("GroceryStore/CustomerDetails.csv",customer);

            string [] booking=new string[Operations.bookingsList.Count];
            for(int i=0;i<Operations.bookingsList.Count;i++)
            {
                booking[i]=Operations.bookingsList[i].BookingId+","+Operations.bookingsList[i].CustomerID+","+Operations.bookingsList[i].TotalPrice+","+Operations.bookingsList[i].DateOfBooking+","+Operations.bookingsList[i].BookingStatus;
            }
            File.WriteAllLines("GroceryStore/BookingDetails.csv",booking);

            string[] order =new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                order[i]=Operations.orderList[i].OrderId+","+Operations.orderList[i].BookingId+","+Operations.orderList[i].ProductId+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceofOrder;
            }
            File.WriteAllLines("GroceryStore/OrderDetails.csv",order);

            string[] product=new string[Operations.productList.Count];
            for(int i=0;i<Operations.productList.Count;i++)
            {
                product[i]=Operations.productList[i].ProductId+","+Operations.productList[i].ProductName+","+Operations.productList[i].QuantityAvailable+","+Operations.productList[i].PricePerQuantity;
            }
            File.WriteAllLines("GroceryStore/ProductDetails.csv",product);
        }
    }
}