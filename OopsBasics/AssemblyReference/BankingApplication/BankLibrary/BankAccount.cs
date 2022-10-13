using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankLibrary;
public enum Gender{Default,Male,Female,Transgender}
public enum AccountType{Default,SB,FD,RD}

    public class BankAccounts
    {
     //private string _name=" sudharsan";//field declaration

     //public string Name { get{return _name;} set{_name=value;} }
    private static int s_accountNumber=3000;
     public string AccountNumber { get;}
     
     
    public string Name { get; set; } //auto property
    public string FatherName { get; set; }
    public DateTime DOB { get; set; }
    public Gender Gender { get; set; }
    public long Phone { get; set; }
    public AccountType AccountType { get; set; }
    public double Balance { get; set; }
    
    

    //parameterized constructor
    public BankAccounts( string name,string fatherName,Gender gender,DateTime dob,long phone,AccountType acctType)
    {
        s_accountNumber++;
        AccountNumber="SF"+s_accountNumber;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        DOB=dob;
        Phone=phone;
        AccountType=acctType;

    }

    public void Deposit()
    {
        System.Console.WriteLine("Enter amount to deposit: ");
        double deposit=double.Parse(Console.ReadLine());
        Balance= Balance+deposit;
        System.Console.WriteLine("Total balance after deposit is: "+Balance);
    }

    public void Withdrawl()
    {
        System.Console.WriteLine("Enter the amount to Withdrawl: ");
        double withdrawl=double.Parse(Console.ReadLine());
        Balance=Balance-withdrawl;
        System.Console.WriteLine("Total amount after withdrawl is: "+Balance);
    }

    public void ShowBalance()
    {
        System.Console.WriteLine("The balance is your account is: "+Balance);
    }
    }  

