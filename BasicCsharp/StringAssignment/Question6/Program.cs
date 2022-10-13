using System;
namespace Question6;
class program{
    public static void Main(string[] args)
    {
        string str;
        int alphabet=0,number=0,specialCharacter=0;
        System.Console.WriteLine("Enter a string: ");
        str=(Console.ReadLine()).ToLower();
        for(int i=0;i<str.Length-1;i++){
            if(str[i]>='a' && str[i]<='z'){
                alphabet++;
            }
            else if(str[i]>='0' && str[i]<='9'){
                number++;
            }
            else{
                specialCharacter++;
            }
        }
        System.Console.WriteLine("The Alphabet in the string is: "+alphabet);
        System.Console.WriteLine("The Number in the string is  : "+number);
        System.Console.WriteLine("The Special Character in the string is: "+specialCharacter);
    }
}