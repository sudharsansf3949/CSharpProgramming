using System;

namespace FoodDelivery
{
    public delegate void EventManager();
    public static class Operations
    {
        public static event EventManager eventLink=null;
        public static CustomerRegistration currentCustomer=null;
        public static List<CustomerRegistration> customerList=new List<CustomerRegistration>();
        public static List<PersonalDetails> personalDetails=new List<PersonalDetails>();
        public static List<FoodDetails>foodList=new List<FoodDetails>();
        public static List<BookingDetails> bookList=new List<BookingDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();


        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select option 1.Customer Registration 2.Customer Login 3.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Customer Registration");
                        CustomerRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        CustomerLogin();
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
            System.Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("ENter Your Father Name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your gender Male or Female");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Mobile Number: ");
            long mobile=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Dato of Birth in dd/mm/yyyy");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your mail ID: ");
            string mailId=Console.ReadLine();
            System.Console.WriteLine("Enter your location: ");
            string location=Console.ReadLine();
            System.Console.WriteLine("Enter your Wallet balance: ");
            int walletBalance=int.Parse(Console.ReadLine()) ;           
            System.Console.WriteLine("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your city: ");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter Phone number: ");
            long phone=int.Parse(Console.ReadLine());
            CustomerRegistration customer=new CustomerRegistration(name,fatherName,gender,mobile,dob,mailId,location,walletBalance);
            customerList.Add(customer);
            System.Console.WriteLine("Registered Successfully");
            System.Console.WriteLine("Your Login Id is: "+customer.CustomerId);
        }

        public static void CustomerLogin()
        {
            System.Console.WriteLine("Enter a customer id: ");
            string id=Console.ReadLine().ToUpper();
            foreach(CustomerRegistration customer in customerList)
            {
                if(customer.CustomerId==id)
                {
                    System.Console.WriteLine("Login Successfull");
                    currentCustomer=customer;
                    SubMenu();
                }
            }
        }

        public static void Subscribe()
        {
            eventLink +=new EventManager(Files.Create);
            eventLink +=new EventManager(Files.WritetoFiles);
            eventLink +=new EventManager(Operations.MainMenu);
            eventLink +=new EventManager(Files.WritetoFiles);
        }

        public static void StartEvent()
        {
            Subscribe();
            eventLink();
        }

        public static void SubMenu()
        {
            string choice ="yes";
            do
            {
                System.Console.WriteLine("Seelct option 1.Show Food Items 2.Order food 3.Cancel order 4.order history 5.Recharge Wallet 6.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        ShowFoodItems();
                        break;
                    }
                    case 2:
                    {
                        OrderFood();
                        break;
                    
                    }

                    case 3:
                    {
                        CancelOrder();
                        break;
                    }
                    case 4:
                    {
                        RechargeWallet();
                        break;
                    }
                    case 5:
                    {
                        break;
                    }
                    case 6:
                    {
                        choice="no";
                        break;
                    }
                    
                }
            }while(choice=="yes");
        }

        public static void ShowFoodItems()
        {
            foreach(FoodDetails food in foodList)
            {
                System.Console.WriteLine("The food Id is     : "+food.FoodId);
                System.Console.WriteLine("The food name is   : "+food.FoodName);
                System.Console.WriteLine("The price per quantity is: "+food.Price);
            }
        }

        public static void OrderFood()
        {
            BookingDetails booking=new BookingDetails(currentCustomer.CustomerId,0,DateTime.Now,BookingStatus.Initiated);
            List<OrderDetails >temp=new List<OrderDetails>();
            int totalPrice=0;
            string choice="yes";
            do
            {
                ShowFoodItems();
                System.Console.WriteLine("Select the food id in the above list: ");
                string id=Console.ReadLine().ToUpper();
                foreach(FoodDetails food in foodList)
                {
                    if(food.FoodId==id)
                    {
                        System.Console.WriteLine("Enter the qunatity: ");
                        int quantity=int.Parse(Console.ReadLine());
                        int amount=quantity*food.Price;
                        OrderDetails order=new OrderDetails(booking.BookingId,food.FoodId,quantity,amount);
                        temp .Add(order);
                        System.Console.WriteLine("Order placed successfully");
                    }
                }
                System.Console.WriteLine("Do you want to add another food yes or no");
                choice=Console.ReadLine().ToLower();
            }while(choice=="yes"); 

            System.Console.WriteLine("Do you want to order the food yes or no");
            string userChoice=Console.ReadLine().ToLower();
            foreach(OrderDetails order in temp)
            {
                totalPrice+=order.PriceOfOrder;
            }
            if(userChoice =="yes")
            {
                string option="yes";
                while(option=="yes")
                {
                    if(totalPrice<=currentCustomer.WalletBalance)
                    {
                        currentCustomer.WalletBalance-=totalPrice;
                        booking.BookingStatus=BookingStatus.Booked;
                        booking.TotalPrice=totalPrice;
                        bookList.Add(booking);
                        orderList.AddRange(temp);
                        System.Console.WriteLine("Booking Confirmed and your booking id is: "+booking.BookingId);
                        option="no";
                    }
                    else
                    {
                        System.Console.WriteLine("Insufficient balance please recharge");
                        RechargeWallet();

                    }
                }
                
            }
        }

        public static void CancelOrder()
        {
            foreach(BookingDetails booking in bookList )
            {
                if(currentCustomer.CustomerId==booking.CustomerId)
                {
                    if(booking.BookingStatus==BookingStatus.Booked)
                    {
                        foreach(OrderDetails order in orderList)
                        {
                            if(booking.BookingId==order.BookingId)
                            {
                                System.Console.WriteLine("Your Order Id is   : "+order.OrderId);
                                System.Console.WriteLine("YOur booking id is : "+order.BookingId);
                                System.Console.WriteLine("Your Food id is    : "+order.FoodId);
                                System.Console.WriteLine("Your food count is : "+order.PurchaseCount);
                                System.Console.WriteLine("Your total bill is : "+order.PriceOfOrder);
                            }
                        }
                        System.Console.WriteLine("Select the order id to cancel: ");
                        string id=Console.ReadLine().ToUpper();
                        foreach(OrderDetails order in orderList)
                        {
                            if(id==order.OrderId)
                            {
                                order.PurchaseCount=0;
                                currentCustomer.WalletBalance+=order.PriceOfOrder;
                                System.Console.WriteLine("Order Cancelled sucessfully ");
                            }
                        }
                        
                    }
                }
            }
        }

        public static void RechargeWallet()
        {
           currentCustomer.WalletRecharge();
        }

        public static void OrderHistory()
        {
            foreach(BookingDetails booking in bookList)
            {
                if(currentCustomer.CustomerId==booking.CustomerId)
                {
                    foreach(OrderDetails order in orderList)
                    {
                        if(booking.BookingId==order.BookingId)
                        {
                            if(booking.BookingStatus==BookingStatus.Booked)
                            {
                                System.Console.WriteLine("Your book id is: "+booking.BookingId);
                                System.Console.WriteLine("The total value for your order is: "+booking.TotalPrice);

                            }
                        }
                    }
                }
            }
        }
    }
}