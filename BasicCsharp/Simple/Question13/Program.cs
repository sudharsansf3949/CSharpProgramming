using System;
namespace Question13;
class program{
    public static void Main(string[] args)
    {
        int num,val=0;
        System.Console.WriteLine("Enter the number: ");
        num=int.Parse(Console.ReadLine());
        for(int i=1;i<=20;i++){
            val=num*i;
            System.Console.WriteLine($" {num} * {i}= {val}");
        }
    }
}