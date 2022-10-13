using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceApplication
{
    
    public static class Operations
    {
        static CustomerDetails currentCustomer=null;
        static List<CustomerDetails> customerList=new List<CustomerDetails>();
        static List<OrderDetails> orderList=new List<OrderDetails>();
        static List<ProductDetails> productList=new List<ProductDetails>();



        public static void DefaultData()
        {
            CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",94455757,5000,"ravi@mail");
            CustomerDetails customer2=new CustomerDetails("Baskarn","Chennai",98885747,6000,"baskaran@mail");
            customerList.Add(customer1);
            customerList.Add(customer2);

            OrderDetails order1=new OrderDetails("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Booked);
            OrderDetails order2=new OrderDetails("CID1003","PID103",40000,DateTime.Now,2,OrderStatus.Booked);
            orderList.Add(order1);
            orderList.Add(order2);

            ProductDetails product1=new ProductDetails("Mobile",10000,10,3);
            ProductDetails product2=new ProductDetails("Tablet",15000,5,2);
            ProductDetails product3=new ProductDetails("Camera",20000,3,4);
            ProductDetails product4=new ProductDetails("iPhone",50000,5,6);
            ProductDetails product5=new ProductDetails("Laptop",40000,3,3);
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
        }


        public static void MainMenu()
        {
            DefaultData();
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select option 1.Customer Registration 2.Login and Purchase 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Welcome to Customer Registration");
                        CustomerRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Welcome to Login and Purchase");
                        LoginPurchase();
                        break;
                    }
                    case 3:
                    {
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");

        }


        public static void CustomerRegistration()
        {
            System.Console.WriteLine("Enter the Customer Details...");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Enter your Name: ");
            string customerName=Console.ReadLine();
            System.Console.WriteLine("Enter your City: ");
            string customerCity=Console.ReadLine();
            System.Console.WriteLine("Enter your Phone Number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Wallet Balance: ");
            double walletBalance=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Mail id: ");
            string mailId=Console.ReadLine();
            
            CustomerDetails customer=new CustomerDetails(customerName,customerCity,phoneNumber,walletBalance,mailId);
            customerList.Add(customer);

            System.Console.WriteLine("Your Customer Id is: "+customer.CustomerId);
        }


        public static void LoginPurchase()
        {
            System.Console.WriteLine("Enter a customer Id: ");
            string id=Console.ReadLine().ToUpper();
            foreach(CustomerDetails customer in customerList)
            {
                if(customer.CustomerId==id)
                {
                    System.Console.WriteLine("Login Successful");
                    currentCustomer=customer;
                    SubMenu();
                }
            }
           
        }


        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Enter option......");
                System.Console.WriteLine("a.Purchase b.Order history c.cancel order d.Wallet Balance e.Exit");
                char option=char.Parse(Console.ReadLine());
                switch(option)
                {
                    case 'a':
                    {

                        Purchase();
                        break;
                    }
                    case 'b':
                    {
                        OrderHistory();
                        break;
                    }
                    case 'c':
                    {
                        CancelOrder();
                        break;
                    }
                    case 'd':
                    {
                        WalletBalance();
                        break;
                    }
                    case 'e':
                    {
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }


        public static void Purchase()
        {
            System.Console.WriteLine("The list of products available in this site are...");
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine("The product Id is: "+product.ProductId);
                System.Console.WriteLine("The product name is: "+product.ProductName);
                System.Console.WriteLine("The Product Price is: "+product.ProductPrice);
                System.Console.WriteLine("The product stock are: "+product.ProductStock);
                System.Console.WriteLine("The product Shipping duration is :"+product.ShippingDuration);

            }
            System.Console.WriteLine("Select the product Id you want ");
            String option=(Console.ReadLine().ToUpper());
            
            foreach(ProductDetails product in productList)
            {
                if(option ==product.ProductId)
                {
                    System.Console.WriteLine("Enter the amount of quantity you want: ");
                    int quantity =int.Parse(Console.ReadLine());
                    if(product.ProductStock>=quantity)
                    {
                       int deliveryCharge=50;
                       double totalAount=(double) (quantity*product.ProductPrice)+deliveryCharge;
                       if(currentCustomer.WalletBalance>=totalAount)
                       {                    
                        currentCustomer.WalletBalance=currentCustomer.WalletBalance-totalAount;
                        product.ProductStock--;
                        foreach(OrderDetails order in orderList)
                        {
                            OrderDetails order1 =new(currentCustomer.CustomerId,product.ProductId,product.ProductPrice,DateTime.Now,quantity,order.OrderStatus);
                            orderList.Add(order1);
                            order.OrderStatus=OrderStatus.Booked;
                            System.Console.WriteLine("Order palced Successfull and your order id is: "+order.OrderId);
                            System.Console.WriteLine("Yur Order was delivered within "+product.ShippingDuration+" days");
                            break;
                        }
                       }
                       else
                       {
                        System.Console.WriteLine("you have insufficient amount to purchase Please recharge your wallet");
                        double reqAmount=currentCustomer.walletRecharge(totalAount-currentCustomer.WalletBalance);
                        currentCustomer.WalletBalance=reqAmount;
                        System.Console.WriteLine("Continue Shopping");

                       }

                    }
                }
            }
        }


        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if(order.CustomerId==currentCustomer.CustomerId)
                {
                    foreach(ProductDetails product in productList)
                    {
                        if(order.CustomerId==currentCustomer.CustomerId)
                        {
                            System.Console.WriteLine("The order made by you was: "+order.ProductId);
                            System.Console.WriteLine("The product name was: "+product.ProductName);
                            System.Console.WriteLine("The quantity you purchase was: "+order.Quantity);
                            System.Console.WriteLine("The bill value is: "+order.TotalPrice);
                        }
                    }
                }
            }
        }


        public static void CancelOrder()
        {
            OrderHistory();
            System.Console.WriteLine("Select the order Id to be cancel");
            string id=Console.ReadLine().ToUpper();
            foreach(OrderDetails order in orderList)
            {
                if(id==order.OrderId)
                {
                    int qty=order.Quantity;
                    double amt=order.TotalPrice;
                    foreach(ProductDetails product in productList)
                    {
                        if(order.ProductId==product.ProductId)
                        {
                            product.ProductStock=product.ProductStock+qty;
                            currentCustomer.WalletBalance=currentCustomer.WalletBalance+amt;
                            order.OrderStatus=OrderStatus.Cancelled;
                            System.Console.WriteLine("The order is cancelled successfully");

                        }
                    }
                }
            }

        }

        public static void WalletBalance()
        {
            
            System.Console.WriteLine("Your Wallet balance is: "+currentCustomer.WalletBalance);
            System.Console.WriteLine("If you want to recharge your wallet yes or no");
            string option=Console.ReadLine().ToLower();
            if(option=="yes")
            {
                System.Console.WriteLine("Enter the amount to be Recharge : ");
                double amt=int.Parse(Console.ReadLine());
                double totalAmt=currentCustomer.walletRecharge(amt);
                System.Console.WriteLine("Amount added Successfully");
                System.Console.WriteLine("The upadated wallet amount is"+currentCustomer.WalletBalance);
            }
            else
            {
                SubMenu();
            }
            
        }
        
    }
}