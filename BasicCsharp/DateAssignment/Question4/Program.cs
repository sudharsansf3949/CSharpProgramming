using System;
namespace Question4;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a date dd/MM/yyyy");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        DayOfWeek day=date.DayOfWeek;
        System.Console.WriteLine($"The day of week for {date.ToShortDateString()} is {day}");
    }
}