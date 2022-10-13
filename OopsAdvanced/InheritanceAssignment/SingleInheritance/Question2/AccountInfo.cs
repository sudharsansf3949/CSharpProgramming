using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class AccountInfo:PersonalInfo
    {
        
        public string AccountNumber { get; set; }
        public int  AccountBalance { get; set; }
        public string Branch { get; set; }
        public string  IFSC { get; set; }



        public AccountInfo(string accountNumber,int accountBalance,string branch,string ifsc,string name,string fatherName,Gender gender,long phone,DateTime dob,string mailId):base( name, fatherName, gender, phone, dob, mailId)
        {
            
            AccountNumber=accountNumber;
            AccountBalance=accountBalance;
            Branch=branch;
            IFSC=ifsc;
        }

        public void ShowAccountInfo()
        {
            ShowDetaials();
            System.Console.WriteLine("Your Account Number is        : "+AccountNumber);
            System.Console.WriteLine("Your Account Balance is       : "+AccountBalance);
            System.Console.WriteLine("Your Account Branch is        : "+Branch);
            System.Console.WriteLine("Your IFSC code is             : "+IFSC);
        }

        public void Deposit()
        {
            System.Console.WriteLine("Enter amount to deposit");
            int amount=int.Parse(Console.ReadLine());
            AccountBalance+=amount;
            System.Console.WriteLine("Amount deposited Successfully");
            ShowBalance();

        }

        public void Withdrawl()
        {
            System.Console.WriteLine("Enter the amount to withdrawl");
            int amount=int.Parse(Console.ReadLine());
            if(AccountBalance>=amount)
            {
                AccountBalance-=amount;
                System.Console.WriteLine("Amount withdrawl successfully");
                ShowBalance();
            }

        }

        public void ShowBalance()
        {
            System.Console.WriteLine("Your current Balance is : "+AccountBalance);

        }
    }
}
