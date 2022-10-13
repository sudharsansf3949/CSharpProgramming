using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Food"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory ("Food");
            }
            if(!File.Exists("Food/CustomerRegistration.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create(("Food/CustomerRegistration.csv"));
            }
            if(!File.Exists("Food/productDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Food/productDetails.csv");
            }
            if(!File.Exists("Food/bookingDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Food/bookingDetails.csv");
            }
            if(!File.Exists("Food/orderDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Food/orderDetails.csv");
            }

        }

        public static void ReadFile()
        {
            string [] customer=File.ReadAllLines("Food/CustomerRegistration.csv");
            foreach(string data in customer)
            {
                CustomerRegistration customers=new CustomerRegistration(data);
                Operations.customerList.Add(customers);
            }
            string []  product=File.ReadAllLines("Food/productDetails.csv");
            foreach(string data in product)
            {
                FoodDetails products=new FoodDetails(data);
                Operations.foodList.Add(products);
                
            }

            string [] booking=File.ReadAllLines("Food/bookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails bookings =new BookingDetails(data);
                Operations.bookList.Add(bookings);
            }

            string [] order=File.ReadAllLines("Food/orderDetails.csv");
            foreach(string data in order)
            {
                OrderDetails orders =new OrderDetails(data);
                Operations.orderList.Add(orders);
            }    
        }

        public static void WritetoFiles()
        {
            string [] customersDetails=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customersDetails[i]=Operations.customerList[i].CustomerId+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].Mobile+","+Operations.customerList[i].DOB+","+Operations.customerList[i].Location+","+Operations.customerList[i].WalletBalance;
            }
            File.WriteAllLines("Food/CustomerRegistration.csv",customersDetails);

            string[] productDetails=new string[Operations.foodList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                productDetails[i]=Operations.foodList[i].FoodId+","+Operations.foodList[i].FoodName+","+Operations.foodList[i].Price;
            }
            File.WriteAllLines("Food/productDetails.csv",productDetails);

            string [] bookingDetails=new string[Operations.bookList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                bookingDetails[i]=Operations.bookList[i].BookingId+","+Operations.bookList[i].CustomerId+","+Operations.bookList[i].TotalPrice+","+Operations.bookList[i].DateOfBooking+","+Operations.bookList[i].BookingStatus;
            }
            File.WriteAllLines("Food/bookingDetails.csv",bookingDetails);

            string []  orderDetails=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i] =Operations.orderList[i].OrderId+","+Operations.orderList[i].BookingId+","+Operations.orderList[i].FoodId+","+Operations.orderList[i].PurchaseCount+","+Operations.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("Food/orderDetails.csv",orderDetails);

        }
    }
}