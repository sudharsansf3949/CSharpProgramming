using System;
namespace LeapYear;
class program
{
    public static void Main(string[] args)
    {
        int year;
        System.Console.WriteLine("Enter a year: ");
        year = Convert.ToInt32(Console.ReadLine());
        if(year%4==0)
        {
            System.Console.WriteLine(year+" is a leap year");
        }
        else
        {
            System.Console.WriteLine("It is not a leap year");
        }
        
    }
}