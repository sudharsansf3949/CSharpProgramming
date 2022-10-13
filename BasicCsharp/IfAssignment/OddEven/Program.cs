using System;
namespace OddEven;
class program{
    public static void Main(string[] args)
    {
        int num;
        System.Console.WriteLine("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num%2 == 0)
        {
            System.Console.WriteLine($"{num} is an even integer");
        }else{
            System.Console.WriteLine($"{num} is an odd integer");
        }
    }
}