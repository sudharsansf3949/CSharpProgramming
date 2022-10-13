using System;
namespace SwitchAssignment2;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter 0,1,2,3,4,5,6");
        int choice=Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 0:
            {
                System.Console.WriteLine("Sunday");
                break;
            }
            case 1:
            {
                System.Console.WriteLine("Monday");
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Tuesday");
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Wednesday");
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Thursday");
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Friday");
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Saturday");
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