using System;
namespace Question10;
class program{
    public static void Main(string[] args)
    {
        char letter;
        System.Console.WriteLine("Enter a letter: ");
        letter=char.Parse(Console.ReadLine());
        
        if(letter == 'a'||letter=='e'||letter=='i'||letter=='o'||letter=='u'){
            System.Console.WriteLine("It is vowel");
        }
        else{
            System.Console.WriteLine("It is not a vowel");
        }
    }
}