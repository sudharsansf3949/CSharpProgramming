using System;
namespace InsertionSort;
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

        int temp=0;
        for(int i=1;i<size;i++)
        {
            int key=array[i];
            for(int j=i-1;j>=0;j--)
            {
                if(key<array[j])
                {
                    temp=array[j];
                    array[j]=array[j+1];
                    array[j+1]=temp;
                }
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