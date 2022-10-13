using System;
namespace Temperature;
class program
{
    public static void Main(string[] args)
    {
        int temp;
        System.Console.WriteLine("Enter the Temperature:");
        temp= Convert.ToInt32(Console.ReadLine());
        if(temp<0)
        {
            System.Console.WriteLine("Its Freezing weather");
        }
        else if(temp==0 && temp<10)
        {
            System.Console.WriteLine("Its very cold weather");
        }
        else if(temp>=10 && temp<20)
        {
            System.Console.WriteLine("Its cold weather");
        }
        else if(temp>=20 && temp<30)
        {
            System.Console.WriteLine("Temperature is normal");
        }
        else if(temp>30 && temp<40)
        {
            System.Console.WriteLine("Its hot weather");
        }
        else if(temp>=40)
        {
            System.Console.WriteLine("Its very hot weather");
        }
        
        
    }
}