using System;
namespace FindString;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array: ");
        int size=int.Parse(Console.ReadLine());
        string[] array=new string[size];
        
        System.Console.WriteLine(" Enter string in asscending order");
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine($"Enter elemnet for {i} position");
            array[i]=Console.ReadLine();
        }
        System.Console.WriteLine(" ");
        System.Console.WriteLine("The Elements are");

        for(int i=0;i<size;i++)
        {
            System.Console.Write(array[i]+"\t");
        }
        System.Console.WriteLine(" ");

        System.Console.WriteLine("Enter the String to be search");
        string elemnet=Console.ReadLine();
        int searchIndex=Array.IndexOf(array,elemnet);

        int begining=0;
        int end=size-1;
        while(begining<=end)
        {
            int mid=(begining+end)/2;
            if(searchIndex==mid)
            {
                System.Console.WriteLine("The element found at"+mid);
                break;
            }
            else if(searchIndex<=mid)
            {
                end=mid-1;
            }
            else
            {
                begining=mid+1;
            }
        }

    }
}