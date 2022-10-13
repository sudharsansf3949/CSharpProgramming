using System;
using System.Collections.Generic;
namespace Question11;
class program{
    public static void Main(string[] args)
    {
        string str1;
        string str2="";
        System.Console.WriteLine("Enter a string: ");
        str1=Console.ReadLine();
        var hashSet=new HashSet<char>(str1);
        foreach(char c in hashSet){
            str2 +=c;
        }
        System.Console.Write("After removing duplicate string: "+str2);
    } 
}