using System;
namespace PyramidPattern;
class program{
    public static void Main(string[] args)
    {
        int space,len=1,count;
        System.Console.WriteLine("Enter the number: ");
        count=Convert.ToInt32(Console.ReadLine());
        space=count-1;
        for(int i=1;i<=count;i++)
        {
            for(int r=space;r>=1;r--)
            {
                System.Console.Write(" ");
            }
            for(int s=1;s<=i;s++)
            {
                System.Console.Write("* ");
               
            }
        
            space--;
            System.Console.WriteLine(" ");
        }
        
    }
}