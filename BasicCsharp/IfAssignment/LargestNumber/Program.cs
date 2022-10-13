using System;
namespace LargestNumber;
class program
{
    public static void Main(string[] args)
    {
        int num1,num2,num3;
        System.Console.WriteLine("Enter the 1st number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the 2nd number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the 3st number: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        if(num1>num2 && num1>num3)
        {
            System.Console.WriteLine("The 1st number is greatest amoug three");

        }
        else if(num2>num1 && num2>num3)
        {
            System.Console.WriteLine("The 2nd number is greatest among three");
        }
        else
        {
            System.Console.WriteLine("The 3rd number is greatest among three");
        }
    }
}