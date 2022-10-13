using System;
namespace Character;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array: ");
        int size=int.Parse(Console.ReadLine());
        char[] array=new char[size];
        System.Console.WriteLine(" Enter character in asscending order");
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine($"Enter elemnet for {i} position");
            array[i]=char.Parse(Console.ReadLine());
        }
        System.Console.WriteLine(" ");
        System.Console.WriteLine("The Elements are");

        for(int i=0;i<size;i++)
        {
            System.Console.Write(array[i]+"\t");
        }
        System.Console.WriteLine(" ");

        System.Console.WriteLine("Enter the char to be search");
        char elemnet=char.Parse(Console.ReadLine());

        int begining=0;
        int end=size-1;
        while(begining<=end)
        {
            int mid=(begining+end)/2;
            if(elemnet==array[mid])
            {
                System.Console.WriteLine("The element found at"+mid);
                break;
            }
            else if(elemnet<array[mid])
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