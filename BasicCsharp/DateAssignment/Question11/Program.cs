using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        DateTime date1=new DateTime();
        DateTime date=DateTime.Now;
        System.Console.WriteLine(date.ToString("MMMM"));
        for(int i=0;i<12;i++)
        {
            date1=date.AddDays(30);
            System.Console.WriteLine(date1.ToString("MMMM"));
            date=date1;

        }
    }
}