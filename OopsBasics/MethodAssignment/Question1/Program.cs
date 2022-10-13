using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        int number1,number2;
        System.Console.WriteLine("Enter number 1: ");
        number1=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter number 2: ");
        number2=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Addition: "+Addition(number1,number2));
        System.Console.WriteLine("Subraction: "+Subraction(number1,number2));
        System.Console.WriteLine("Multiplication: "+Mulitiplication(number1,number2));
        System.Console.WriteLine("Division: "+Division(number1,number2));

        int Addition(int num1,int num2)
        {
            int sum=num1+num2;
            return sum;
        }
        int Subraction(int num1,int num2)
        {
            int sub=num1-num2;
            return sub;
        }
        int Mulitiplication(int num1,int num2)
        {
            int mul=num1*num2;
            return mul;
        }
        int Division(int num1,int num2)
        {
            int div=num1/num2;
            return div;
        }
        
    }
}