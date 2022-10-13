using System;
namespace Question6;
class program{
    public static void Main(string[] args)
    {
        
    int price, tax;
    Console.WriteLine("Enter the price: ");
    price = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the tax: ");
    tax = Convert.ToInt32(Console.ReadLine());
    double totalAmount = price+(price*0.18);
    System.Console.WriteLine("The total Value is: "+totalAmount);

        
    }
}