using System;
namespace Question3;
class program{
    public static void Main(string[] args)
    {
        string str1,str2;
        System.Console.WriteLine("Enter first string : ");
        str1=Console.ReadLine();
        System.Console.WriteLine("Enter second string: ");
        str2=Console.ReadLine();
        char[] ch1=str1.ToLower().ToCharArray();
        char[] ch2=str2.ToLower().ToCharArray();
        Array.Sort(ch1);
        Array.Sort(ch2);
        string str3=ch1.ToString().ToLower();
        string str4=ch2.ToString().ToLower();
        if(str3==str4)
        {
            System.Console.WriteLine("Two strings are anagrams");

        }
        else
        {
            System.Console.WriteLine("Not anagrams");
        }
    }
}