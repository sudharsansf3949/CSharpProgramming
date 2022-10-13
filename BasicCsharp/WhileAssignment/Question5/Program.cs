using System;
namespace Question5;
class program{
    public static void Main(string[] args)
    {
        int num,sum=0,i=1;
        System.Console.WriteLine("Enter the nmber of terms: ");
        num=int.Parse(Console.ReadLine());
        while(i<=num)
        {
            System.Console.WriteLine("Enter numbers: ");
            int number=int.Parse(Console.ReadLine());
            sum=sum+number;
            i++;
        }
        System.Console.WriteLine("The sum od digits is: "+sum);
        
    }
}