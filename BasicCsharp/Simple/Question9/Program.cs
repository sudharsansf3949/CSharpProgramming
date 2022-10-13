using System;
namespace Question9;
class program{
    public static void Main(string[] args)
    {
        string month;
        int days=0,leave,salary=0;
        System.Console.WriteLine("Enter the month: ");
        month=Console.ReadLine().ToLower();
        System.Console.WriteLine("Enter number of leave taken: ");
        leave=int.Parse(Console.ReadLine());

        if(month=="january" || month=="march" || month=="may" || month=="july" || month=="august" || month=="october"||month=="december"){
            days=31;
        }
        else if(month=="feburary"||month=="apirl"||month=="june"||month=="september"||month=="november"){
            days=30;
        }
        
        days=days-leave;
        salary=days*500;
        System.Console.WriteLine("The salary is: "+salary);

        
        
    }
}