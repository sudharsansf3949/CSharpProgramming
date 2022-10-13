using System;
namespace Question4;

class program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the cylinder: ");
        int radius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Height of cylinder: ");
        int Height = Convert.ToInt32(Console.ReadLine());
        double volume = (3.14*radius*radius*Height);
        Console.WriteLine("Volume: "+volume);
    }
}