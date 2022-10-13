using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBill
{
    public static class Operations
    {
        static BillDetails currentBill=null;
         static List<BillDetails> detail=new List<BillDetails>();

         public static void ManiMenu()
         {
            string choice ="yes";
            do
            {
                System.Console.WriteLine("Enter option 1.Register 2.Login 3.Exit");
                int option=int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {
                        break;
                    }
                    case 2:
                    {
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

         public static void Registration()
         {

            System.Console.WriteLine("Enter the Bill details");
            System.Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter phone number: ");
            long number=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mail id: ");
            string mail=Console.ReadLine();
            System.Console.WriteLine("Enter number of units used: ");
            double unit=double.Parse(Console.ReadLine()); 
            BillDetails billDetail=new BillDetails (name,mail,number,unit);
            detail.Add(billDetail); 
            System.Console.WriteLine("Your bill number is: "+billDetail.MeterId);          
         }

        public static void Login()
        {
         System.Console.WriteLine("Enter meter id: ");
         string meterId=Console.ReadLine().ToUpper();
         foreach(BillDetails bill in detail)
         {
            System.Console.WriteLine("Login Successfull");
            currentBill=bill;
            SubMenu();
         }

        }
        public static void SubMenu()
        {
            string choice ="yes";
            do
            {
                System.Console.WriteLine("Enter submenu option: ");
                System.Console.WriteLine("1.Show details 2.Units 3.Traiff 4.Exit");
                int option =int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        currentBill.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        currentBill.CalculateAmount(100);
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

    }



}