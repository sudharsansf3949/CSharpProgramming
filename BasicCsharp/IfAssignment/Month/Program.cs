using System;
namespace Month;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month: ");
        String month=Console.ReadLine();
        String a=month.ToLower();
        if(a == "december" || a=="january"|| a=="february")
        {
            System.Console.WriteLine("Its Winter season");
        }
        else if(a=="march"|| a=="april"|| a=="may")
        {
            System.Console.WriteLine("Its Spring season");
        }
        else if(a=="june"|| a=="july"||a=="august")
        {
            System.Console.WriteLine("Its Summer season");
        }
        else if(a=="september"||a=="october"||a=="november")
        {
            System.Console.WriteLine("Its Rainfall season");
        }
    }
}