using System;
namespace OperatorOverloading
{
    class Program{
        public static void Main(string[] args)
        {
            Box box1=new Box (1.2,3.4,5.6);
            Box box2=new Box(11.1,1.11,1.11);
            Box box3;
            double volume=0.0;

            volume =box1.CalculateVolume();
            System.Console.WriteLine("Volume o Box1: "+volume);

            volume =box2.CalculateVolume();
            System.Console.WriteLine("\n Volume of Box2: "+volume);

            box3=box1+box2;
            volume =box3.CalculateVolume();
            System.Console.WriteLine("\n Volume of Box3: "+volume);
            
        }
    }
}