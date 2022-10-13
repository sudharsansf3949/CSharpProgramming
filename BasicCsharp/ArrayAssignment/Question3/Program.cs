using System;
namespace Question3;
class program{
    public static void Main(string[] args)
    {
        int len,sum=0;
        System.Console.WriteLine("Enter the number of elements ");
        len=Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[len];
        for(int i=0;i<len;i++)
        {
            System.Console.WriteLine("Enter the elements: ");
            numbers[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        for(int i=0;i<len;i++)
        {
            sum=sum+numbers[i];

        }
        System.Console.WriteLine(sum);

    }
}