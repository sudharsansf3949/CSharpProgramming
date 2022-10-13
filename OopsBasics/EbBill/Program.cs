using System;
using System.Collections.Generic;
namespace EbBill;
class program{
    public static void Main(string[] args)
    {
        List<BillDetails> detail=new List<BillDetails>();

        System.Console.WriteLine("Are you willing to add another bill");
        string choice=Console.ReadLine().ToLower();

        while(choice=="yes")
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

            System.Console.WriteLine("Are you willing to add another bill");
            choice=Console.ReadLine().ToLower();

        }

        foreach(BillDetails bill in detail)
        {
            System.Console.WriteLine("Details of              : "+bill.UserName);
            System.Console.WriteLine("  ");
            System.Console.WriteLine("Name of the user         : "+bill.UserName);
            System.Console.WriteLine("Phone number of user     : "+bill.PhoneNumber);
            System.Console.WriteLine("Mail id of the User      : "+bill.MailId);
            System.Console.WriteLine("Units used by the user   : "+bill.UnitsUsed);
            bill.CalculateAmount(bill.UnitsUsed);
        }
    }
}