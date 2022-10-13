using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        string choice="yes";
        AccountInfo member=new AccountInfo("H100093",50000,"Anna Nagar","HDFC1001","Sudharsan","Karthikeyan",Gender.Male,989987798,new DateTime(19/04/2000),"Sudahr@gmail");
        //member.ShowDetaials();

        do
        {
            System.Console.WriteLine("select option 1.Update 2.Show Account Info 3.Deposit 4.Withdraw 5.Show Balance");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Update the details");

                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Show account info");
                    member.ShowAccountInfo();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Deposit");
                    member.Deposit();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Withdraw");
                    member.Withdrawl();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Show balance");
                    member.ShowBalance();
                    break;
                }

            }
        }while(choice=="yes");
    }
}