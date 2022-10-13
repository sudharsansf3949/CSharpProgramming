using System;
namespace SwitchAssignment4;
class program
{
    public static void Main(string[] args)
    {
        int num1,num2 ,choice;
        Console.WriteLine("Enter the first number: ");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter 1-Addition, 2-Subraction, 3-Multiplication, 4-Division, 5-Exit");
        choice=Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine("The Addition of values is"+(num1+num2));
                break;
            }
            case 2:
            {
                System.Console.WriteLine("The Subraction of values is"+(num1-num2));
                break;
            }
            case 3:
            {
                System.Console.WriteLine("The Multiplication of values is"+(num1*num2));
                break;
            }
            case 4:
            {
                System.Console.WriteLine("The division of values is"+(num1/num2));
                break;
            }
            case 5:
            {
                break;
            }
            default :
            {
                System.Console.WriteLine("Invalid Input");
                break;
            }
        }
    }
}