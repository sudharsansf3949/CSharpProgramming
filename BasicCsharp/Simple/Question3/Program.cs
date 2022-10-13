using System;
namespace Question3;
class program{
    public static void Main(string[] args)
    {
        double celcius,farenheit;
        System.Console.WriteLine("Enter the celcius: ");
        celcius=double.Parse(Console.ReadLine());
        farenheit=celcius*(9/5)+32;
        System.Console.WriteLine($"The fahrenheit is: {farenheit}");
        
    }
}