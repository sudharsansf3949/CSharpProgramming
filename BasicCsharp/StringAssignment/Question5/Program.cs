using System;
namespace Question5;
class program{
    public static void Main(string[] args)
    {
        string str1,str2;
        System.Console.WriteLine("Enter string 1: ");
        str1=Console.ReadLine();
        System.Console.WriteLine("Enter string2: ");
        str2=Console.ReadLine();
        if(str1==str2){
            System.Console.WriteLine("Both are equal Strings...");
        }
    }
}