using System;
namespace Question5;
class program{
    public static void Main(string[] args)
    {
        int len;
        System.Console.WriteLine("Enter the number of elements ");
        len=Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[len];
        int[] even=new int[len];
        int[] odd=new int[len];
        for(int i=0;i<len;i++)
        {
            System.Console.WriteLine("Enter the elements: ");
            numbers[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<len;i++)
        {
            if(numbers[i]%2==0)
            {
                even[i]=numbers[i];

            }
            else{
                odd[i]=numbers[i];
            }
        
        }
        System.Console.WriteLine("The even numbers: ");
        for(int i=0;i<even.Length;i++)
        {
            System.Console.Write(even[i]+" ");
        }
        System.Console.WriteLine("The odd numbers: ");
        for(int i=0;i<odd.Length;i++)
        {
            System.Console.Write(odd[i]+" ");
        }
    }
}