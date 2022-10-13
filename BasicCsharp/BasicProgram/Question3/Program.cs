using System;
namespace Question3;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount of Celcius: ");
        int celcius =Convert.ToInt32(Console.ReadLine());
        int fahrenheit = (celcius*9/5)+32;
        double kelvin = celcius+273.15;
        Console.WriteLine("Fahernheit = "+fahrenheit);
        Console.WriteLine("Kelvin = "+kelvin);
    }

}