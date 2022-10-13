using System;
namespace Question1;
class program{
    public static void Main(string[] args)
    {
        double inch=0,centiMeter=0;
        System.Console.WriteLine("Enter inches: ");
        inch=double.Parse(Console.ReadLine());
        centiMeter=inch*2.54;
        System.Console.WriteLine($"The Centimeter for {inch} inch  is : {centiMeter}cm");
        
    }
}