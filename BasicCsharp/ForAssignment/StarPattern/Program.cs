using System;
namespace StarPattern;
class program{
    public static void Main(string[] args)
    {
        for(int i=1;i<=4;i++)
        {
            for(int j=1;j<= 4-i;j++)
            {
                System.Console.Write("");
            }
            for(int k=1;k<=i;k++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine(" ");
        }
    }
}