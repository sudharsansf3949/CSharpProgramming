using System;
namespace Question14;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter year: ");
        int year=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter month: ");
        int month =int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter number of leave taken");
        int leave=int.Parse(Console.ReadLine());
        int days=DateTime.DaysInMonth(year,month);
        System.Console.WriteLine("Your Salary is: "+(days-leave)*500);
    }
}