using System;
namespace Question5;

class program{
    public static void Main(string[] args)
    {
        int maths,physics,chemistry,sum;
        Console.WriteLine("Enter your Maths mark: ");
        maths = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Physics mark: ");
        physics = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Chemistry mark: ");
        chemistry = Convert.ToInt32(Console.ReadLine());
        sum=maths+physics+chemistry;
        double percentage = sum/3;
        Console.WriteLine("Sum        = "+sum);
        Console.WriteLine("Percentage = "+percentage);
    }
}