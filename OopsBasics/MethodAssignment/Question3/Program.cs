using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        int value1,value2;
        System.Console.WriteLine("Enter the 1st number: ");
        value1=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the 2nd number: ");
        value2=Convert.ToInt32(Console.ReadLine());
        Swap(value1,value2);



        void Swap(int num1,int num2)
        {
            int temp=num1;
            num1=num2;
            num2=temp;
            System.Console.WriteLine("Now the first number is: "+num1);
            System.Console.WriteLine("Now the second number is: "+num2);
        }
        
        
    }
}