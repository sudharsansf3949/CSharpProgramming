using System;
namespace Question13;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter day: ");
        int day=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter a month : ");
        int month=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter year");
        int year=int.Parse(Console.ReadLine());
        DateTime date=new DateTime(year,month,day);
        System.Console.WriteLine("The date is: "+date.ToString("dd/MM/yyy"));
    }
}