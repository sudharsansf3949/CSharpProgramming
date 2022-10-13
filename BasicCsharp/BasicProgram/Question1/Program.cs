using System;
namespace HelloWorld;
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            String myName = Console.ReadLine();
            Console.WriteLine("Hello:"+myName);
            Console.WriteLine($"Hello:{myName}");
            Console.WriteLine("Hello:{0}",myName);      
        }
    }