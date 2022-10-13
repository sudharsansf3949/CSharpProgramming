using System;
namespace OddSum;
class program
{
    public static void Main(string[] args)
    {
        int num ,sum=0;
        System.Console.WriteLine("Enter the number of terms: ");
        num=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("The  odd numbers are: ");
        for(int i=1;i<=num;i++)
        {
            if(i%2!=0)
            {
                System.Console.WriteLine(i);
                sum=sum+i;
            }
        }
        System.Console.WriteLine("The Sum of odd natural numbers upto "+num+" terms : "+sum);
        
        
    }
   
}
