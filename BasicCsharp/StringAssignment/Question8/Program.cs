using System;
namespace Question8;
class program{
    public static void Main(string[] args)
    {
        string str;
        int pos,l,ln;
        System.Console.WriteLine("Enter the string: ");
        str=Console.ReadLine();
        ln=str.Length;
        System.Console.WriteLine("Enter the substring position : ");
        pos=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Length of subsstring: ");
        l=int.Parse(Console.ReadLine());
        for(int i=pos-1;i<=l+1;i++){
            System.Console.Write(str[i]);
        }
    
    
        
        
        
    }
} 