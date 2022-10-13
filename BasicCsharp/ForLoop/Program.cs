using System;
namespace ForLoop;
class program
{
    public static void Main(string[] args)
    {
        int i;
        for(i=1;i<=25;i++)
        {
            if(i%2 == 0)
            {
                System.Console.WriteLine(i);
            }
        }
        int intialValue,finalValue,sum=0;
        System.Console.WriteLine("Enter the initial value: ");
        intialValue=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the final value: ");
        finalValue=Convert.ToInt32(Console.ReadLine());
        for(i=intialValue;i<=finalValue;i++)
        {
            sum=sum+(i*i);
        }
        System.Console.WriteLine(sum);
        

        
    }
}