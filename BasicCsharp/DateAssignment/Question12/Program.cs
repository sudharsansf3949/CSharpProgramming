using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Month number: ");
        int month=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Year: ");
        int year=int.Parse(Console.ReadLine());
        int days=DateTime.DaysInMonth(year,month);
        System.Console.WriteLine($"The number of days is: {days}");
        
    }
}