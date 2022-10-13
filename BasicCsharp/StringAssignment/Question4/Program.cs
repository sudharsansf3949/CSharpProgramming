using System;
namespace Question4;
class program{
    public static void Main(string[] args)
    {
        int i=0,count=1;
        System.Console.WriteLine("Enter a string: ");
        string str =Console.ReadLine();
        while(i<=str.Length-1){
            if(str[i]==' '){
                count++;
            }
            i++;
        }
        System.Console.WriteLine("Total sumber of words in a string is: "+count);
       

    }
}