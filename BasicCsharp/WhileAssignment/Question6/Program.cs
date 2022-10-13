using System;
namespace Question6;
class program{
    public static void Main(string[] args)
    {
        int i=1;
        System.Console.WriteLine("The even numbers are");
        while(i<=100)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
            }
            i++;
        }
        System.Console.WriteLine("The odd numbers are");
        int j=1;
        while(j<=100)
        {
            if(j%2!=0)
            {
                System.Console.WriteLine(j);
            }
            j++;
        }
        System.Console.WriteLine("The prime numbers are");
        int num=3,count=0,k=2;
        System.Console.WriteLine("1");
        System.Console.WriteLine("2");
        while(num<=100)
        {
            if(num%k==0)
            {
                
                count=1;
                
            }
            
        
           if(count==0)
            {
                System.Console.WriteLine(num);
            }
            num++;

        }          

        
    }
}