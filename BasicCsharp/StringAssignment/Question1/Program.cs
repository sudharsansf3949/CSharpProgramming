using System;
namespace Question1;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a string: ");
        string val=Console.ReadLine();
        int count=0;
        foreach(char c in val){
            count++;
        }
        System.Console.WriteLine(count);
    }
}