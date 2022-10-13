using System;
namespace MergeSort;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array: ");
        int size=int.Parse(Console.ReadLine());
        int[] array=new int[size];
        System.Console.WriteLine("Enter Elements in array");
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("Enter element for position "+i);
            array[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine(" ");
        System.Console.WriteLine("The elements are");
        for(int i=0;i<size;i++)
        {
            System.Console.Write(array[i]+"\t");
        }
        System.Console.WriteLine("\nMerge sort");
        Operations.SortMerge(array,0,size-1);
        for(int i=0;i<size;i++)
        {
            System.Console.Write(array[i]+"\t");
        }
    }
}