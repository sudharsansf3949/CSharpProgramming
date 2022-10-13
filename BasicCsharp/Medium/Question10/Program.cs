using System;
namespace Question10;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter length: ");
        int length=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Width");
        int width=int.Parse(Console.ReadLine());
        System.Console.WriteLine("");

        for(int i=1;i<=width;i++)
        {
            for(int j=1;j<=length;j++)
            {
                if(i==1||i==width||j==1||j==length)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine(" ");
        }
        
    }
}