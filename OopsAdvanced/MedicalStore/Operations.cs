using System;


namespace MedicalStore
{
    public static class Operations
    {
        public static UserDetails currentUser=null;
        public static List<UserDetails> userList =new List<UserDetails>();
        public static List<MedicineDetails> medicineList=new List<MedicineDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();

        public static void MainMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select option 1.User Registration 2.User Login 3.Order History 4.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("User Registration");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("User Login");
                        userLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Order History");
                        break;
                    }
                    case 4:
                    {
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your name: ");
            string userName=Console.ReadLine();
            System.Console.WriteLine("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your city: ");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter Phone number: ");
            long phone=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Balance: ");
            int balance=int.Parse(Console.ReadLine());
            UserDetails user=new UserDetails(userName,age,city,phone,balance);
            userList.Add(user);
            System.Console.WriteLine("Registered Successfully");
            System.Console.WriteLine("Your Login Id is: "+user.UserId);
        }

        public static void userLogin()
        {
            System.Console.WriteLine("Enter a Login Id: ");
            string id=Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(user.UserId==id)
                {
                    System.Console.WriteLine("Login Successfull");
                    currentUser=user;
                    subMenu();
                }
            }
            
        }

        public static void subMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select Option 1.Show Medicine List 2.Purchase Medicine 3.Cancel Purchase 4. Show Purchaase History 5.Recharge 6.Exit ");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Medicine List");
                        MedicineList();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Purchase Medicine");
                        PurchaseMedicine();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Purchase");
                        CancelOrder();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Purchase History");
                        PurchaseHistory();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Recharge");
                        Rercharge();
                        break;
                    }
                    case 6:
                    {
                        choice ="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
        
        public static void MedicineList()
        {
            System.Console.WriteLine("The list of available medicine in the shop");
            foreach(MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine("The medicine Id is: "+medicine.MedicineId);
                System.Console.WriteLine("The medicine name is: "+medicine.MedicineName);
                System.Console.WriteLine("The medicine count is : "+medicine.Count);
                System.Console.WriteLine("The medicine price is: "+medicine.Price);
                System.Console.WriteLine("The medicine expiry date is: "+medicine.DateOfExpiry);
            }
        }

        public static void PurchaseMedicine()
        {
            System.Console.WriteLine("The medicine available are...");
            MedicineList();
            System.Console.WriteLine("Enter the medicine Id you wants to buy: ");
            string medId=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter the amount of medicine : ");
            int count=int.Parse(Console.ReadLine());
            foreach(MedicineDetails medicine in medicineList)
            {
                int amount=count*medicine.Price;
                if(medId==medicine.MedicineId)
                {
                    if(count<=medicine.Count)
                    {
                        foreach(UserDetails user in userList)
                        {
                            if(amount>=user.Balance&& currentUser.UserId==user.UserId)
                            {
                                
                                foreach(OrderDetails order in orderList)
                                {
                                    order.OrderDate=DateTime.Now;
                                    user.Balance=user.Balance-amount;
                                    medicine.Count=medicine.Count-count;
                                    OrderDetails details=new OrderDetails(amount,DateTime.Now,OrderStatus.Purchased);
                                    orderList.Add(details);
                                    System.Console.WriteLine("Medicine is purchased Successfully");
                                    System.Console.WriteLine("Your Order Id is: "+order.OrderId);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void CancelOrder()
        {
            foreach(OrderDetails order in orderList)
            {
                if(currentUser.UserId==order.UserId)
                {
                    if(order.OrderStatus==OrderStatus.Purchased)
                    {
                        System.Console.WriteLine("The order id is: "+order.OrderId);
                        System.Console.WriteLine("The medicine Id is: "+order.MedicineId);
                        System.Console.WriteLine("The medicine count is: "+order.Count);
                        System.Console.WriteLine("The purchased date is: "+order.OrderDate);
                        System.Console.WriteLine("The total price is: "+order.TotalPrice);
                    }
                    System.Console.WriteLine("Enter the order Id you wants to cancel: ");
                    string id=Console.ReadLine().ToUpper();
                    if(id==order.OrderId)
                    {
                        if(order.OrderStatus==OrderStatus.Purchased)
                        {
                            foreach(MedicineDetails medicine in medicineList)
                            {
                                if(order.MedicineId==medicine.MedicineId)
                                {
                                    medicine.Count=order.Count+medicine.Count;
                                    currentUser.Balance=currentUser.Balance+order.TotalPrice;
                                    order.OrderStatus=OrderStatus.Cancelled;
                                    System.Console.WriteLine($"{order.OrderId} is Cancelled Successfully");
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void PurchaseHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if(currentUser.UserId==order.UserId)
                {
                    if(order.OrderStatus==OrderStatus.Purchased)
                    {
                        System.Console.WriteLine("The order id is: "+order.OrderId);
                        System.Console.WriteLine("The medicine Id is: "+order.MedicineId);
                        System.Console.WriteLine("The medicine count is: "+order.Count);
                        System.Console.WriteLine("The purchased date is: "+order.OrderDate);
                        System.Console.WriteLine("The total price is: "+order.TotalPrice);
                    }
                }
            }  
        }

        public static void Rercharge()
        {
            System.Console.WriteLine("Enter the amount to recharge: ");
            int amount=int.Parse(Console.ReadLine());
            currentUser.Balance+=amount;
            System.Console.WriteLine("The updated balance is : "+currentUser.Balance);
        }
    }
}