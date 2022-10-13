using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId { get; set; }
        public double WalletBalance { get; set; }

        public CustomerRegistration(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailId,string location,double walletBalance):base( name, fatherName, gender, mobile, dob, mailId, location)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            WalletBalance=walletBalance;
        }

        public CustomerRegistration(string Data)
        {
            string [] value=Data.Split(',');
            s_customerId=int.Parse(value[0].Remove(0,3));
            CustomerId=value[0];
            Name=value[1];
            FatherName=value[2];
            Gender=Enum.Parse<Gender>(value[3]);
            Mobile=long.Parse(value[4]);
            DOB=DateTime.Parse(value[5]);
            MailId=value[6];
            Location=value[7];
            WalletBalance=int.Parse(value[8]);
        }

        public void WalletRecharge()
        {
            System.Console.WriteLine("Enter the amount to Recharge");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance +=amount;
        }

        public void ShowCustomer()
        {
            ShowDetails();
            System.Console.WriteLine("Your Customer Id is    : "+CustomerId );
            System.Console.WriteLine("Your Wallet Balance is : "+WalletBalance);
        }


    }
}