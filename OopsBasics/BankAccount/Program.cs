using System;
using System.Collections.Generic;
namespace BankAccount;
class program{
    public static void Main(string[] args)
    {

        List<BankAccounts> accountList=new List<BankAccounts>(); 

        System.Console.WriteLine("Are you Willing to open account....yes or no : ");
        string willing=Console.ReadLine().ToLower();

        while(willing=="yes"){
            
            
            System.Console.WriteLine(" Enter Account details");
            System.Console.WriteLine("Enter yor Name: ");
            string name=Console.ReadLine();

            System.Console.WriteLine("Enter your Father name: ");
            string fatherName=Console.ReadLine();
            
            System.Console.WriteLine("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            
            System.Console.WriteLine("Enter your phone number: ");
            long phone=long.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Enter your Date of Birth in format dd/mm/yyy: ");
            DateTime dob =DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            
            System.Console.WriteLine("Enter Account type: ");
            AccountType acctType=Enum.Parse<AccountType>(Console.ReadLine(),true);


            

            BankAccounts account= new BankAccounts(name,fatherName,gender,dob,phone,acctType);//object declare.....

            accountList.Add(account);

            System.Console.WriteLine("Are you Willing to open account... yes or no:  ");
            willing=Console.ReadLine().ToLower();
        } 
               
        //print Account details

        foreach(BankAccounts account in accountList){

            System.Console.WriteLine("Details of "+account.Name);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Your Name is           : "+account.Name);
            System.Console.WriteLine("Your Father Name is    : "+account.FatherName);
            System.Console.WriteLine("Your Gender is         :  "+account.Gender);
            System.Console.WriteLine("Your Phone Number is   : "+account.Phone);
            System.Console.WriteLine("Your Date of Birth is  : "+account.DOB.ToShortDateString());
            System.Console.WriteLine("Your Account type is   : "+account.AccountType);
            System.Console.WriteLine("Your Account Balance is: "+account.Balance);
            System.Console.WriteLine("Your Account number  is: "+account.AccountNumber);
            account.Deposit();
            account.Withdrawl();
            account.ShowBalance();
            System.Console.WriteLine(" ");
        }

       
    }


}
    
