using System;
using System.Linq;
namespace Question12;
class program{
    public static void Main(string[] args)
    {
        string str;
        System.Console.WriteLine("Enter a string: ");
        str=Console.ReadLine();
        var data=str.Split(' ');
        int[] array=new int[data.Length];
        int j=0;
        foreach(string val in data)
        {
            array[j]=int.Parse(val);
            j++;
        }
        System.Console.WriteLine("Maximum number is "+array.Max());
        System.Console.WriteLine("Minimum number is "+array.Min());

        
        
    }
}