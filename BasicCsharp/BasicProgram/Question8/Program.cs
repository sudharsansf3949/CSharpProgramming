using System;
namespace Question8;
class program
{
    public static void Main(string[] args)
    {
        double meter,cm,mm,inch,foot;
        double mile;
        System.Console.WriteLine("Enter the value in meter: ");
        meter=Convert.ToDouble(Console.ReadLine());
        cm=meter*100;
        mm=cm*10;
        inch=39.3*meter;
        foot=12*meter;
        mile=0.0006213715277778 *meter;
        System.Console.WriteLine("The given value in CentiMeter : "+cm);
        System.Console.WriteLine("The given value in MilliMeter : "+mm);
        System.Console.WriteLine("The given value in Inch       : "+inch);
        System.Console.WriteLine("The given value in Foot       : "+foot);
        System.Console.WriteLine("The given value in Mile       :" +mile);
                       
    }
}