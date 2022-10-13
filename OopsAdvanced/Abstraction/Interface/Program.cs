using System;
namespace Interface;
class Program
{
    public static void Main(string[] args)
    {
        Draw rect=new Draw(10,10);
        rect.Show();
        rect.CalculateArea();
        rect.Show();
    }
    
}
