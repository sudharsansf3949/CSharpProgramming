using System;
namespace Question10
{
   class Program{
    public static void Main(string[] args)
    {

        System.Console.WriteLine("Today: "+DateTime.Now.ToShortDateString());
        System.Console.WriteLine("Yesterday: "+DateTime.Now.AddDays(-1).ToShortDateString());
        System.Console.WriteLine("Tommorrow: "+DateTime.Now.AddDays(1).ToShortDateString());

    }
   } 
}