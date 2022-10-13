using System;
namespace Admission;
class program{
    public static void Main(string[] args)
    {
        int m1,m2,m3,sum;
        System.Console.WriteLine("Enter your Maths mark: ");
        m1=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your Physics mark: ");
        m2=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your Chemistry mark: ");
        m3=Convert.ToInt32(Console.ReadLine());
        sum=m1+m2+m3;
        int percent=sum/3;
        if(percent<=75)
        {
            System.Console.WriteLine("The Candiate is not Eligible for admission");
        }
        else{
            System.Console.WriteLine("The candidate is Eligible for admission");
        }
        
        
    }
}