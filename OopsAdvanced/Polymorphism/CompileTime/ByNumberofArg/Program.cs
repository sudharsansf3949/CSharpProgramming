using System;
namespace ByNumberofArg;
class Program{
    static void Display(int number)       //Method with one parameter
    {
        System.Console.WriteLine("Arguments : "+number);
    }

    
    static void Display(int number1,int number2)    //Method with two parameter
    {
        System.Console.WriteLine($"Arguments {number1} and {number2}");
    }

    static void Main(string[] args)
    {
        Display(100);
        Display(100,200);
        Console.ReadLine();
        
    }
}