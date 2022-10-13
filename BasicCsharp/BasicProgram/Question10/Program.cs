using System;
namespace Question10;
class program
{
    public static void Main(string[] args)
    {
        int num1, num2;
        System.Console.WriteLine("Enter the 1st value: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the 2nd value: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(num1>num2);
        System.Console.WriteLine(num1<num2);
        System.Console.WriteLine(num1>=num2);
        System.Console.WriteLine(num1==num2);
        System.Console.WriteLine(num1!=num2);
        System.Console.WriteLine(num1<=num2);
        System.Console.WriteLine(num1>=10 && num2>=10);
        System.Console.WriteLine(num1>=10 || num2>=10);
        System.Console.WriteLine(!(num1>20));
        System.Console.WriteLine(num1==15?"true":"false");
        System.Console.WriteLine(num1++);
        System.Console.WriteLine(num1--);
    }
}