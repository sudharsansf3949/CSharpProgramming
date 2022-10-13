using System;
namespace Question5;
class program{
    public static void Main(string[] args)
    {
        string str;
        string str1="";
        System.Console.WriteLine("Enter a string: ");
        str=Console.ReadLine();
        for(int i=str.Length-1;i>=0;i--){
            str1=str1+str[i];
        }
        if(str=str1)
        {
            System.Console.WriteLine("It is a palindrome");
        }
        else
        {
            System.Console.WriteLine("It is not a palnidrome");
        }

            
        
    }
}