using System;
namespace SwitchStatement;
class program
{
    public static void Main(string[] args)
    {
        int num1,num2;
        System.Console.WriteLine("Enter the 1st value: ");
        num1=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the 2nd value: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your choice +, -, *, /,%");
        char choice=Convert.ToChar(Console.ReadLine());

        switch(choice)
        {
            case '+':
            {
                System.Console.WriteLine("The sum of value is: "+(num1+num2));
                break;
            }
            case '-':
            {
                System.Console.WriteLine(" The Subraction of value is: "+(num1-num2));
                break;
            }
            case '*':
            {
                System.Console.WriteLine("The Multiplication of value is: "+num1*num2);
                break;
            }
            case '/':
            {
                System.Console.WriteLine("The Division of value is: "+num1/num2);
                break;
            }
            case '%':
            {
                System.Console.WriteLine(" The Modulo division of value is: "+num1%num2);
                break;
            }
            default:
            {
                System.Console.WriteLine("operation Invalid");
                break;
            }
        }
        
        
    }
}