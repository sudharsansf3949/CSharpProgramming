using System;
namespace Question2;
class program
{
    public static void Main(string[] args)
    {
        int num,i=1,sum=0;
        System.Console.WriteLine("Enter the count : ");
        num=Convert.ToInt32(Console.ReadLine());
        while(i<=num)
        {
            System.Console.WriteLine(i);
            sum=sum+(i*i);
            i++;
        }
        System.Console.WriteLine("Square of number is: "+sum);
        
    }
}