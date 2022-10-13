using System;
namespace StringClassrrom;
class Program{
    public static void Main(string[] args)
    {
        string str,subString;
        System.Console.WriteLine("Enter a string: ");
        str= Console.ReadLine();
        System.Console.WriteLine("Enter a sub string: ");
        subString=Console.ReadLine();
        int a=str.Length;
        string[] arr=str.Split(new char[]{subString[0],subString[1]});
        int b=arr.Length;
        int c=(a-b)+1;
        System.Console.WriteLine("The Length is "+(c));
        
        
        
    }
}