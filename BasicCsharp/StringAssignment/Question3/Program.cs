using System;
namespace Question3;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a word: ");
        string str=Console.ReadLine();
        for(int i=str.Length-1;i>=0;i--){
            System.Console.Write(str[i]+" ");
        }
    }
}