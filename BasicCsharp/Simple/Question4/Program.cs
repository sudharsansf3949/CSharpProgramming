using System;
namespace Question4;
class program{
    public static void Main(string[] args)
    {
        int rupees;
        double usd=0.0222,eur=0.0127,cny=0.0879;
        System.Console.WriteLine("Enter the rupees: ");
        rupees=int.Parse(Console.ReadLine());
        usd=rupees*usd;
        eur=rupees*eur;
        cny=rupees*cny;
        System.Console.WriteLine("The rupees for USD is: "+usd);
        System.Console.WriteLine("The rupees for EUR is: "+eur);
        System.Console.WriteLine("The rupees for CNY is: "+cny);
        
    }
}