using System;
namespace Question8;
class program{
    public static void Main(string[] args)
    {
        double speed;
        System.Console.WriteLine("Enter the speed: ");
        speed=double.Parse(Console.ReadLine());
        
        if(speed<=10){
            System.Console.WriteLine("slow");
        }
        else if(speed>10 && speed<=50){
            System.Console.WriteLine("Average");
        }
        else if(speed>50 && speed<=150){
            System.Console.WriteLine("Fast");
        }
        else if(speed>150 && speed<=1000){
            System.Console.WriteLine("Ultra Fast");
        }
        else if(speed>1000){
            System.Console.WriteLine("Extremely Fast");
        }
    }
}