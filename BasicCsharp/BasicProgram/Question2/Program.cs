using System;
namespace Question2;

class program
{
    public static void Main(string[] args)
    {
        int num1,num2;
        Console.WriteLine("Enter the first number: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        Console.WriteLine($"{num1} - {num2} = {num1-num2}");
        Console.WriteLine($"{num1} * {num2} = {num1*num2}");
        Console.WriteLine($"{num1} / {num2} = {num1/num2}");
        Console.WriteLine($"{num1} % {num2} = {num1%num2}");
    
    }
}