using System;
namespace CubeNumbers;
class program
{
    public static void Main(string[] args)
    {
        int i,a;
        System.Console.WriteLine("Enter number of terms: ");
        a=Convert.ToInt32(Console.ReadLine());
        for(i=1;i<=a;i++)
        {
            System.Console.WriteLine("The Cube of " + i + " is: "+(i*i*i));
        }
        
    }
}