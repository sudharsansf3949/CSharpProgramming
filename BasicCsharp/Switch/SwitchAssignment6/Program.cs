using System;
namespace SwitchAssignment6;
class program
{
    public static void Main(string[] args)
    {
        double radius;
        System.Console.WriteLine("Enter the radius of circle");
        radius= Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Enter choices 1-area, 2-perimeter, 3-diameter");
        int choice=Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine("The area of circle is: "+(3.14*radius*radius));
                break;
            }
            case 2:
            {
                System.Console.WriteLine("The perimeter of circle is: "+(2*3.14*radius));
                break;
            }
            case 3:
            {
                System.Console.WriteLine("The diameter of circle is: "+(2*radius));
                break;
            }
            default:
            {
                System.Console.WriteLine("Invaild input");
                break;
            }
        }
    }
}