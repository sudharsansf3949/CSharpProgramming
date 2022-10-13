using System;
namespace MultiplicationTable;
class program
{
    public static void Main(string[] args)
    {
        int i,temp;
        System.Console.WriteLine("Enter the multiplication table: ");
        temp=Convert.ToInt32(Console.ReadLine());
        for(i=1;i<=10;i++)
        {
            System.Console.WriteLine($"{temp} * {i} = {temp*i}");
        }
        
    }
}