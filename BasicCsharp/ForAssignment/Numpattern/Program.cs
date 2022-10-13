using System;
namespace NumPattern;
class program{
    public static void Main(string[] args)
    {
        int space,len=1,count,temp=1;
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
                System.Console.Write( +temp+" ");
                temp++;
               
            }
        
            space--;
            System.Console.WriteLine(" ");
        }
        
    }
}