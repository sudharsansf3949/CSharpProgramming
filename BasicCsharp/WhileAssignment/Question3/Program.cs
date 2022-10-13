using System;
namespace Question3;
class program
{
    public static void Main(string[] args)
    {
        int num ,i=0,j=1;
        System.Console.WriteLine("Enter  the number: ");
        num=Convert.ToInt32(Console.ReadLine()); 
        System.Console.WriteLine(i);      
        while(j<num)
        {
         
          System.Console.WriteLine(j);
          int temp=i+j;
          i=j;
          j=temp;
        }

    }
}