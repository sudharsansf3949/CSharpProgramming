using System;
namespace Question7;
class program{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter a number: ");
        number=int.Parse(Console.ReadLine());
        
        if(number<100){
            System.Console.WriteLine("Less than 100");
        }
        else if(number>=100 && number<=200){
            System.Console.WriteLine("Between 100 and 200");
        }
        else if(number>200){
            System.Console.WriteLine("Greater than 200");
        }
    }
}