using System;
namespace Question11;
class program{
    public static void Main(string[] args)
    {
        int x,y,sum=1;
        System.Console.WriteLine("Enter x: ");
        x=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter y: ");
        y=int.Parse(Console.ReadLine());
        
        for(int i=1;i<=y;i++){
            sum=sum*x;
        }
        System.Console.WriteLine(sum);
    }
}