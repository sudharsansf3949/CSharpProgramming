using System;
namespace GroceryStore;
public delegate void EventManager();
public  class Operations{
    public static event EventManager eventlink=null;
    public static  List<CustomerDetails> customerList=new List<CustomerDetails>();
    public static List<ProductDetails> productList=new List<ProductDetails>();
    public static List<BookingDetails> bookingsList=new List<BookingDetails>();
    public static List<OrderDetails> orderList=new List<OrderDetails>();
    public static CustomerDetails currentCustomer=null;

    public static void Subscribe()
    {
        eventlink +=new EventManager(Files.Create);
        eventlink +=new EventManager(Files.ReadFile);
        eventlink +=new EventManager(Operations.MainMenu);
        eventlink +=new EventManager(Files.WriteFile);
    }

    public static void StartEvent()
    {
        Subscribe();
        eventlink();
    }
    public static void MainMenu()
    {
        DefaultData();
        string choice="yes";
        do
        {
            System.Console.WriteLine("Select the option 1.Customer Registration 2.Customer Login 3.Exit");
            int option =int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    CustomerRegistration();
                    break;
                }
                case 2:
                {
                    CustomerLogin();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exiting MainMenu");
                    choice="no";
                    break;
                }
            }
        }while(choice=="yes");            
    }

    public static void CustomerRegistration()
    {
        System.Console.WriteLine("Enter your Name:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your Father Name");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("Enter your MailId");
        string mailId=Console.ReadLine();
        System.Console.WriteLine("Enter your Mobile Number: ");
        long mobileNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Date of Birth in format dd/MM/yyyy");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter Your Gender male or female");
        Gender gender=Enum .Parse<Gender>(Console.ReadLine());
        System.Console.WriteLine("Enter your Wallet balance: ");
        double walletBalance=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Customer Registration Method Called");
        CustomerDetails customer=new CustomerDetails(name,fatherName,gender,mobileNumber,dob,mailId,walletBalance);
        customerList.Add(customer);
        System.Console.WriteLine("Your Login Id is: "+customer.CustomerId);
    }

    public static void CustomerLogin()
    {
        System.Console.WriteLine("Enter your Customer id: ");
        string id=Console.ReadLine().ToUpper();
        bool flag=true;
        foreach(CustomerDetails customer in customerList)
        {
            if(id==customer.CustomerId)
            {
                System.Console.WriteLine("Login successful");
                flag=false;
                currentCustomer=customer;
                SubMenu();
            }
        }

        if(flag)
        {
            System.Console.WriteLine("Invalid Customer Id");
        }
    }

    public static void SubMenu()
    {
        string choice ="yes";
        do
        {
            System.Console.WriteLine("Select option 1.Show customer Details 2.Show Product details 3.Wallet recharge 4.Take Order 5.Modify order 6.Cancel order 7.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case(1):
                {
                    System.Console.WriteLine("Show Customer Details");
                    ShowCustomer();
                    break;
                }
                case(2):
                {
                    System.Console.WriteLine("Show Product Details");
                    ShowProducts();
                    break;
                }
                case(3):
                {
                    System.Console.WriteLine("Wallet Recharge");
                    WalletRecharge();
                    break;
                }
                case(4):
                {
                    System.Console.WriteLine("Take Order");
                    TakeOrder();
                    break;
                }
                case(5):
                {
                    System.Console.WriteLine("Modify order");
                    ModifyOrder();
                    break;
                }
                case(6):
                {
                    System.Console.WriteLine("Cancel Order");
                    CancelOrder();
                    break;
                }
                case(7):
                {
                    choice ="no";
                    break;
                }
            }
        }while(choice=="yes");
    }

    public static void  DefaultData()
    {
        //customer details data
        CustomerDetails customer1=new CustomerDetails("Ravi","Ettaparajan",Gender.male,9921983217,new DateTime(1999,11,11),"ravi@gmail",1000);
        CustomerDetails customer2=new CustomerDetails("Baskaran","Sethurajan",Gender.male,847575775,new DateTime(1999,11,11),"baskaran@gmail.com",15000);
        customerList.Add(customer1);
        customerList.Add(customer2);

        //Product details
        ProductDetails product=new ProductDetails("sugar",20,40);
        ProductDetails product1=new ProductDetails("Rice",100,50);
        ProductDetails product2=new ProductDetails("Milk",10,40);
        ProductDetails product3=new ProductDetails("Coffee",10,10);
        ProductDetails product4=new ProductDetails("Tea",10,10);
        ProductDetails product5=new ProductDetails("Masala Powder",10,20);
        ProductDetails product6=new ProductDetails("Salt",10,10);
        ProductDetails product7=new ProductDetails("Turmeric Powder",10,25);
        ProductDetails product8=new ProductDetails("Chilli Powder",10,20);
        ProductDetails product9=new ProductDetails("Groundnut Oil",10,140);
        productList.Add(product);
        productList.Add(product1);
        productList.Add(product2);
        productList.Add(product3);
        productList.Add(product4);
        productList.Add(product5);
        productList.Add(product6);
        productList.Add(product7);
        productList.Add(product8);
        productList.Add(product9);

        //Order details
        OrderDetails order1=new OrderDetails("BID3001","PID101",2,80);
        OrderDetails order2=new OrderDetails("BID3001","PID102",2,100);
        OrderDetails order3=new OrderDetails("BID3001","PID103",1,40 );
        OrderDetails order4=new OrderDetails("BID3002","PID101",1,40 );
        OrderDetails order5=new OrderDetails("BID3002","PID102",4,200);
        OrderDetails order6=new OrderDetails("BID3002","PID110",1,140);
        OrderDetails order7=new OrderDetails("BID3002","PID109",1,20 );
        OrderDetails order8=new OrderDetails("BID3003","PID102",2,100);
        OrderDetails order9=new OrderDetails("BID3003","PID108",4,100);
        OrderDetails order10=new OrderDetails("BID3003","PID101",2,80 );
        orderList.Add(order1);
        orderList.Add(order2);
        orderList.Add(order3);
        orderList.Add(order4);
        orderList.Add(order5);
        orderList.Add(order6);
        orderList.Add(order7);
        orderList.Add(order8);
        orderList.Add(order9);
        orderList.Add(order10);

        //Booking details

        BookingDetails booking1=new BookingDetails("CID3001",220,new DateTime(2022,07,06),BookingStatus.Booked );
        BookingDetails booking2=new BookingDetails("CID3002",400,new DateTime(2022,07,06),BookingStatus.Booked);
        BookingDetails booking3=new BookingDetails("CID3001",280,new DateTime(2022,07,06),BookingStatus.Cancelled);
        BookingDetails booking4=new BookingDetails("CID3002",0,  new DateTime(2022,07,06),BookingStatus.Initiated);
        bookingsList.Add(booking1);
        bookingsList.Add(booking2);
        bookingsList.Add(booking3);
        bookingsList.Add(booking4);
    }

    public static  void ShowCustomer()
    {
        currentCustomer.ShowCustomerDetails();
    }

    public static  void ShowProducts()
    {
        foreach(ProductDetails products in productList)
        {
            products.ShowProduct();
        }
    }

    public static  void WalletRecharge()
    {
        currentCustomer.WalletRecharge();
    }

    public static  void TakeOrder()
    {

        //create booking object
        BookingDetails booking=new BookingDetails(currentCustomer.CustomerId,0,DateTime.Now,BookingStatus.Initiated);
        List<OrderDetails>temp=new List<OrderDetails>();
        double totalPrice=0;
        //declare loop
        string choice="yes";
        do
        {
            //show product list
            ShowProducts();
            //get product id and check for product 
            System.Console.WriteLine("Select the product Id in the above List");
            string id=Console.ReadLine().ToUpper();
            
            foreach(ProductDetails products in productList)
            {
                if(products.ProductId==id)
                {
                    //get the quantity and compare with availability
                    System.Console.WriteLine("Enter the quantity you want:");
                    int quantity=int.Parse(Console.ReadLine());
                    double amount=quantity*products.PricePerQuantity;

                    if(products.QuantityAvailable>=quantity)
                    {
                        //take order and create object and add in local order list
                        OrderDetails order=new OrderDetails(booking.BookingId,products.ProductId,quantity,amount);
                        temp.Add(order);
                        products.QuantityAvailable-=quantity;
                        System.Console.WriteLine("Order placed Successfully");
                        
                    }
                    else
                    {
                        System.Console.WriteLine("Quantity not Available");
                    }
                }
                else
                {
                    System.Console.WriteLine("Invalid Product Id");
                }
            }
            System.Console.WriteLine("Do you want to add another product yes or no....");
            choice=Console.ReadLine().ToLower();
        }while(choice=="yes");
        
        
        System.Console.WriteLine("Do you want the order the products yes or no");
        string userChoice=Console.ReadLine().ToLower();
        foreach(OrderDetails order in temp)
        {
            totalPrice+=order.PriceofOrder;
        }
        if(userChoice=="yes")
        {
            string option="yes";
            while(option=="yes")
            {
                if(totalPrice<=currentCustomer.WalletBalance)
                {
                    currentCustomer.WalletBalance-=totalPrice;
                    booking.BookingStatus=BookingStatus.Booked;
                    booking.TotalPrice=totalPrice;
                    bookingsList.Add(booking);
                    orderList.AddRange(temp);
                    System.Console.WriteLine("Booking Conformed"+booking.BookingId);
                    option="no";
                }
                else
                {
                    double reqAmount=totalPrice-currentCustomer.WalletBalance;
                    System.Console.WriteLine($"Your Total bill value is {totalPrice} you have low balance the required amount is {reqAmount} ");
                    System.Console.WriteLine("Please Recharge your wallet");
                    WalletRecharge();
                }
            } 
        }
        else
        {
            foreach(OrderDetails order in orderList)
            {
                foreach(ProductDetails product in productList)
                {
                    if(order.ProductId==product.ProductId)
                    {
                        product.QuantityAvailable+=order.PurchaseCount;
                    }
                }  
            }
        }     
    }

    public static void ModifyOrder()
    {

    }
    public static void CancelOrder()
    {
        foreach(BookingDetails booking in bookingsList)
        {
            if(currentCustomer.CustomerId==booking.CustomerID)
            {
                if(booking.BookingStatus==BookingStatus.Booked)
                {
                    booking.BookingStatus=BookingStatus.Cancelled;
                    currentCustomer.WalletBalance+=booking.TotalPrice;
                }
            }
        }
        //check customer id is in booking in booking details
        //Enter the booking id
        //if status book change to cancel
    }

}
