using System;
using System.Collections.Generic;
class program{
    public static void Main(string[] args)
    {
        string str1,str2="";
        System.Console.WriteLine("Enter a string: ");
        str1=Console.ReadLine();
        var hashSet=new HashSet<char>(str1);
        foreach(char c in hashSet){
            str2=str2+c;
        }
        System.Console.WriteLine(str2);
    }
}