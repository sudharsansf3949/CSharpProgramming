using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number: ");
        number=Convert.ToInt32(Console.ReadLine());
        Fibonacci(number);
        

        void Fibonacci(int number)
        {
            int value2=1,value3,value=0;
            System.Console.Write("0  ");
            System.Console.Write("1  ");
            for(int i=1;i<=number-2;i++)
            {
                value3=value+value2;
                value=value2;
                value2=value3;
                System.Console.Write(value3+"  ");
            }
        }
        
    }
}