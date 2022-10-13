using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter starting Date in Format dd/MM/yyyy");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter last date in format dd/MM/yyyy");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        int value=DateTime.Compare(date1,date2);
        if(value>0)
        {
            System.Console.WriteLine($"{date1.ToShortDateString()} is later tha {date2.ToShortDateString()}");
        }
        else if(value<0)
        {
            System.Console.WriteLine($"{date1.ToShortDateString()} is earlier than {date2.ToShortDateString()}");

        }
        else
        {
            System.Console.WriteLine($"{date1.ToShortDateString()} is same as {date2.ToShortDateString()}");
        }

    }
}