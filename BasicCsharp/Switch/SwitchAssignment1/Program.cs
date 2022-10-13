using System;
namespace SwitchAssignment1;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter E, V,G,A,F");
        char choice=Convert.ToChar(Console.ReadLine());
        switch (choice)
        {
            case 'E':
            {
                System.Console.WriteLine("Excelent");
                break;
            }
            case 'V':
            {
                System.Console.WriteLine("Very good");
                break;
            }
            case 'G':
            {
                System.Console.WriteLine("Good");
                break;
            }
            case 'A':
            {
                System.Console.WriteLine("Average");
                break;
            }
            case 'f':
            {
                System.Console.WriteLine("Fail");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;
            }
        }
        
    }
}