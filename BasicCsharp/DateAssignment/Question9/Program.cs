using System;
namespace Question9;
class program{
    public static void Main(string[] args)
    {
        
        for(int i=1994;i<=2014;i++)
        {
            if(DateTime.IsLeapYear(i))
            {
                System.Console.WriteLine($"{i} is a Leap Year");
                
            }
        }             
    }
}