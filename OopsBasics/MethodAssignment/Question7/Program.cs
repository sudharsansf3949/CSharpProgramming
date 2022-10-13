using System;
namespace Question7;
class program{
    public static void Main(string[] args)
    {
        string original,rev="";
        System.Console.WriteLine("Enter a word: ");
        original= Console.ReadLine();
        int a=original.Length;
        Palindrome(original);
        void Palindrome(string original)
        {
            for(int i=a-1;i>=0;i--)
        {
            rev+=original[i].ToString();
        }
        if(original==rev)
        {
            System.Console.WriteLine("Its palindrome");
        }
        else
        {
            System.Console.WriteLine("Its not a palindrome");
        }
    
        }
    
        
    }
}