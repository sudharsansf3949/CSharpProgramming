using System;
namespace Integer;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Size of array: ");
        int size=int.Parse(Console.ReadLine());
        int[] array=new int[size];
        System.Console.WriteLine("Enter Elements is asscending order");
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine($"Enter {i} Elemnet");
            array[i]=int.Parse(Console.ReadLine());
        }

        System.Console.WriteLine("The elements are  ");
        for(int i=0;i<size;i++)
        {
            System.Console.Write(array[i]+"\t");
            
        }
        System.Console.WriteLine("");
        System.Console.WriteLine("Enter the Elemnts to be find: ");
        int element=int.Parse(Console.ReadLine());

        int begining=0;
        int end=size-1;
        while(begining<=end )
        {
            int mid=(begining+end)/2;
            if(array[mid]==element)
            {
                System.Console.WriteLine("The Element found at " +mid+ " Position ");
                break;
            }
            else if(element<array[mid])
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