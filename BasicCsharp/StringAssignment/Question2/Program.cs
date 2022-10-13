using System;
namespace Question2;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a word: ");
        string str=Console.ReadLine();
        for(int i=0;i<=str.Length-1;i++){
            System.Console.Write(str[i]+" ");
        }
    }
}