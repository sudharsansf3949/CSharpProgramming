using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId { get; }
        public double WalletBalance { get; set; }
        
        public CustomerDetails(string name,string fatherName,Gender gender,long mobilenumber,DateTime dob,string mailId,double walletBalance):base( name, fatherName, gender, mobilenumber, dob, mailId)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            WalletBalance=walletBalance;
        }

        public CustomerDetails(string Data)
        {
            string [] value=Data.Split(',');
            s_customerId=int.Parse(value[0].Remove(0,3));
            CustomerId=value[0];
            Name=value[1];
            FatherName=value[2];
            Gender=Enum.Parse<Gender>(value[3]);
            MobileNumber=long.Parse(value[4]);
            DOB=DateTime.Parse(value[5]);
            MailId=value[6];
            WalletBalance=double.Parse(value[7]);
        }

        public void ShowCustomerDetails()
        {
            ShowPerson();
            System.Console.WriteLine("Your Customer Id is : "+CustomerId);
            System.Console.WriteLine("Your Wallet Balance is :"+WalletBalance);
            System.Console.WriteLine(" ");
        }

        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to recharge");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance+=amount;
            System.Console.WriteLine("Your updated balance is: "+WalletBalance);
        }
    }
}