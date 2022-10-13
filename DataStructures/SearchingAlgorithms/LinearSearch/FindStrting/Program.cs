using System;
namespace FindString;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of Element in array: ");
        int size=int.Parse(Console.ReadLine());

        string[] array=new string[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine($"Enter {i}th Element");
            array[i]=Console.ReadLine();
        }

        System.Console.WriteLine("The elements in the array");
        for(int i=0;i<size;i++)
        {
           System.Console.Write( array[i]+"\t");
           
        }
        System.Console.WriteLine("");
        
        System.Console.WriteLine("Enter the Element to be search: ");
        string searchElement=Console.ReadLine();
        bool flag=false;
        for(int i=0;i<size;i++)
        {
            
            if(array[i]==searchElement)
            {
                System.Console.WriteLine($"Element found at {i} position");
                flag=true;
                break;
            }
        }
        if(!flag)
        {
            System.Console.WriteLine("Elemnt not found");
        }
    }
}