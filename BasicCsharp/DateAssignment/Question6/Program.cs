using System;
namespace Question6;
class program{
    public static void Main(string[] args)
    {
        DateTime date1=new DateTime();
        DateTime date=DateTime.Now;
        System.Console.WriteLine("Now the day is: "+date);
        date1=date1.AddDays(40);
        System.Console.WriteLine("After adding 40 days: "+date1);
        DayOfWeek day=date.DayOfWeek;
        System.Console.WriteLine("The day is: "+day);
        
    }
}