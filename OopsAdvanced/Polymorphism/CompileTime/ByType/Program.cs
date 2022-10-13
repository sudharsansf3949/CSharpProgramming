using System;
namespace ByType;
class Program{
    static void Display(int number)       //Method with one parameter
    {
        System.Console.WriteLine("Arguments : "+number);
    }

    
    static void Display(string name)    //Method with two parameter
    {
        System.Console.WriteLine($"Arguments {name}");
    }

    static void Main(string[] args)
    {
        Display(100);
        Display("Sudharsan");
        Console.ReadLine();
        
    }
}