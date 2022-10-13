using System;
namespace Question2;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter date in format dd/MM/yyyy and time in hh:ss;mm");
        DateTime date1= DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        System.Console.WriteLine("The complete date is: "+date1.ToShortDateString() +" "+date1.ToShortTimeString());
        System.Console.WriteLine("The Short date is: "+date1.ToShortDateString());
        System.Console.WriteLine(date1.ToLongDateString() +" "+date1.ToShortTimeString());
        System.Console.WriteLine(date1.ToShortDateString());
        System.Console.WriteLine(date1.ToShortTimeString());

    }
}