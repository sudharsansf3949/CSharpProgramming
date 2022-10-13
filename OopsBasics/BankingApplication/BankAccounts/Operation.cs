using System;
using System.Collections.Generic;

namespace BankAccounts;

public static class Operation{

    static BankAccounts currentAccount=null;

    static List<BankAccounts> accountList=new  List<BankAccounts> ();
    public static void MainMenu()
    {

      string willing="yes"; 

      do{


        System.Console.WriteLine("Select option 1.Registration 2.Login 3.Exit ");
        int option=int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("Registration");
                Registration();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Login");
                Login();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Exit");
                willing="no";
                break;
            }

        }
      }while(willing=="yes");


             
    }

    public static void Registration()
    {

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

        System.Console.WriteLine("Yor account Id is: "+account.AccountNumber);

    }


    public static void Login()
    {
        System.Console.WriteLine("Enter your Account number: ");
        string accountNumber=Console.ReadLine().ToUpper();

        foreach(BankAccounts account in accountList)
        {
            if(account.AccountNumber==accountNumber)
            {
                System.Console.WriteLine("Login Successfull");
                currentAccount=account;
                SubMenu();
            }
            else{
                System.Console.WriteLine("Invalid number");
            }

        }
        
                
    }
    public static void SubMenu()
    {

        String choice="yes";
        do{

            System.Console.WriteLine("Enter sub menu options");
            System.Console.WriteLine("1. Show details 2.Deposit 3. withdrawl 4.show balance 5.exit");
            int option=int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    currentAccount.ShowDetails();
                    break;
                }
                case 2:
                {
                    currentAccount.Deposit();
                    break;
                }
                case 3:
                {
                    currentAccount.Withdrawl();
                    break;
                }
                case 4:
                {
                    currentAccount.ShowBalance();
                    break;
                }
                case 5:
                {
                    choice="no";
                    break;
                }
            }
        }while(choice=="yes");
        


    }


}
    
