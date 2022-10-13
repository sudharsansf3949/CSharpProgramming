using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        int mark1,mark2,mark3;
        System.Console.WriteLine("Enter mark1: ");
        mark1=Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("Enter mark2: ");
        mark2=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter mark3: ");
        mark3=Convert.ToInt32(Console.ReadLine());

        Marks(mark1, mark2, mark3);
        
        void Marks(int m1,int m2,int m3)
        {
            int sum,percentage;
            sum=m1+m2+m3;
            percentage=sum/3;
            System.Console.WriteLine("Percentage: "+percentage);
        }
        
    }
}