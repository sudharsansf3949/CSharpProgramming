using System;
namespace Array;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the length of array: ");
        int len = Convert.ToInt32(Console.ReadLine());
        String [] names=new String[len];
        System.Console.WriteLine("Enter the names ");
        for(int i=0;i<len;i++)
        {
            names[i] = Console.ReadLine();
        }
        System.Console.WriteLine("The names stored in the array is:");
        for(int i=0;i<len;i++)
        {
            System.Console.WriteLine(names[i]);
        }
        System.Console.WriteLine("Enter the name to be search: ");
        string searchWord=Console.ReadLine().ToLower();
        int val=0;
        for(int i=0;i<len;i++)
        {
            if(searchWord==names[i])
            {
                System.Console.WriteLine("The name is present in the array of index "+i);
                val++;

            }
        }
        if(val==0)
        {
            System.Console.WriteLine("The name is not present");
        }
        int a=0;            
        foreach(string stdNames in names)
        {
            if(stdNames==searchWord)
            {
                System.Console.WriteLine("The name present in array");
                a++;
            }
        }
        if(a==0)
        {
            System.Console.WriteLine("The name is not present");
        }
        
        
    }
}