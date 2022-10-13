using System;
namespace Question2;
class program{
    public static void Main(string[] args)
    {
        double radius, area,perimeter;
        System.Console.WriteLine("Enter the radius of the circle: ");
        radius=double.Parse(Console.ReadLine());
        area=Math.PI*radius*radius;
        perimeter=2*Math.PI*radius;
        System.Console.WriteLine("The Area of circle is      : "+area);
        System.Console.WriteLine("The perimeter of circcle is: "+perimeter);
    }
}