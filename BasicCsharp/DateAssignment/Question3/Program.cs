using System; 
namespace Question3;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a date and time in format dd/MM/yyyy hh:mm:ss:ff ");
        DateTime value=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss:ff",null);
        int day=value.Day;
        int year=value.Year;
        int month=value.Month;
        int  hour=value.Hour;
        int min=value.Minute;
        int sec=value.Second;
        int mm=value.Millisecond;
        System.Console.WriteLine(value.ToString("dd"));
        System.Console.WriteLine("Day="+day);
        System.Console.WriteLine("Month="+month);
        System.Console.WriteLine("Year="+year);
        System.Console.WriteLine("Hour="+hour);
        System.Console.WriteLine("Minutes="+min);
        System.Console.WriteLine("Seconds="+sec);
        System.Console.WriteLine("MilliSeconds="+mm);
    }
}