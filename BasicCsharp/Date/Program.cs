using System;
namespace Date;
class program{
    public static void Main(string[] args)
    {
        DateTime dob = new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine(dob.Year);
        System.Console.WriteLine(dob.Month);
        System.Console.WriteLine(dob.Date);
        System.Console.WriteLine(dob.Hour);
        System.Console.WriteLine(dob.Minute);
        System.Console.WriteLine(dob.Second);
        
        System.Console.WriteLine("Enter the date in dd/MM/yyyy format");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine(date.ToString("dd/MM/yyy"));
        string date=date.ToString();
        System.Console.WriteLine(date);
    }
}