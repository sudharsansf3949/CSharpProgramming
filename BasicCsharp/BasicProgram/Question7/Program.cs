using System;
namespace Question7;
class program
{
    public static void Main(string[] args)
    {
        int a,b, c;
        System.Console.WriteLine("Enter the value for a: ");
        a=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the value for b: ");
        b=Convert.ToInt32(Console.ReadLine());
        c=(a*a)+(2*a*b)+(b*b);
        System.Console.WriteLine("The value is: "+c);
        
    }
}