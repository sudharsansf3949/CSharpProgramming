using System;
namespace SumAversge;
class program
{
    public static void Main(string[] args)
    {
        int i,sum=0,temp;
        System.Console.Write("Enetr 10 numbers:");
        for(i=0;i<10;i++)
        {
            temp=Convert.ToInt32(Console.ReadLine());
            sum=sum+temp;
        }
        float avg=(float)sum/10;
        System.Console.WriteLine("The sum is      :"+sum);
        System.Console.WriteLine("The average is  :"+avg);
    }
}