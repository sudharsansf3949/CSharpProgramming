using System;
namespace Question6;
class progam{
    public static void Main(string[] args)
    {
        int n;
        System.Console.WriteLine("Enter the number of elements: ");
        n=int.Parse(Console.ReadLine());
        int[] numbers=new int[n];
        for(int i=0;i<n;i++){
            System.Console.WriteLine("Enter the elements: ");
            numbers[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Original Array");
        foreach(int i in numbers){
            System.Console.Write(i +" ");
        }
        Array.Sort(numbers);
        System.Console.WriteLine();
        System.Console.WriteLine("Sorted Array");
        foreach(int i in numbers){
            System.Console.Write(i+ " ");
        }
    }
}