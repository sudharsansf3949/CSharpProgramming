using System;
namespace SelectionSort;
class Program{
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

        int minValue,minIndex,temp=0;
        for(int i=0;i<size;i++)
        {
            minIndex=i;
            minValue=array[i];
            for(int j=i;j<size;j++)
            {
                if(array[j]<minValue)
                {
                    minValue=array[j];
                    minIndex=j;
                }
            }
            if(minValue<array[i])
            {
                temp=array[i];
                array[i]=array[minIndex];
                array[minIndex]=temp;
            }

        }
        System.Console.WriteLine(" ");
        System.Console.WriteLine("The sorted elements are");
        foreach(int a in array)
        {
            System.Console.Write(a+" \t");
        }
    }
}