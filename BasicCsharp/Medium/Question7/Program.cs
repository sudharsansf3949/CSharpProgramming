using System;
namespace Question7;
class program{
    public static void Main(string[] args)
    {
        int num,diff,elements;
        System.Console.WriteLine("Enter the starting number: ");
        num=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the difference: ");
        diff=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number of elements: ");
        elements=int.Parse(Console.ReadLine());
        System.Console.Write(num+" ");
        int sum=num;
        for(int i=0;i<elements-1;i++){
            num=num+diff;
            sum=sum+num;
            System.Console.Write(num+" ");
            
        }
        System.Console.WriteLine(" ");
        System.Console.WriteLine("The sum of series is: "+sum);
        
    }
}