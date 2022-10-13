using System;
namespace PrimeNumber;
class program{
    public static void Main(string[] args)
    {
        int i=0,num,count=0;
        System.Console.WriteLine("Enter the number: ");
        num=Convert.ToInt32(Console.ReadLine()); 
        int m=num/2;   
        for(i=2;i<=m;i++)
        {
            if(num%i==0)
            {
                System.Console.WriteLine("Its not a prime number");
                count++;
                break;
            }
        }
        if(count==0 )
        {
            System.Console.WriteLine("Its a prime");
                
        }
        
    }
}