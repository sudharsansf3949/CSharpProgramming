using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int num;
        System.Console.WriteLine("Enter the number: ");
        num=Convert.ToInt32(Console.ReadLine());

        PrimeNumber(num);
        void PrimeNumber(int num)
        {
            int count=0;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }
                
            }
            if(count==0)
            {
                System.Console.WriteLine("Its prime");
            }
            else
            {
                System.Console.WriteLine("Its not a prime");
            }
        }
        
    }
}