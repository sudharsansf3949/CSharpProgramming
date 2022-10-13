using System;
namespace Question9;
class program{
    public static void Main(string[] args)
    {
        string str1,str2;
        bool temp;
        System.Console.WriteLine("Enter a string: ");
        str1=Console.ReadLine();
        System.Console.WriteLine("Enetr substring: ");
        str2=Console.ReadLine();
        temp=str1.Contains(str2);
        if(temp==true){
            System.Console.WriteLine("The string is present");

        }
        else{
            System.Console.WriteLine("The string is not present");
        }
    
        
    }
}