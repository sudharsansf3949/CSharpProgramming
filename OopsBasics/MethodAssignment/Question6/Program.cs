using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        int value1;
        System.Console.WriteLine("Enter the number: ");
        value1=Convert.ToInt32(Console.ReadLine());
        int val=Factorial(value1);
        System.Console.WriteLine("The factorial of given number is: "+val);


        int Factorial(int num1)
        {
            int fact=1;
            for(int i=1;i<=num1;i++)
            {
                fact=fact*i;
                
            }
            return fact;
        }
        
    }
}