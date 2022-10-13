using System;
namespace SugarLevel;
class program
{
    public static void Main(string[] args)
    {
        int sugarLevel;
        System.Console.WriteLine("Enter the Sugar Level: ");
        sugarLevel= Convert.ToInt32(Console.ReadLine());
        if(sugarLevel<90 && sugarLevel<0)
        {
            System.Console.WriteLine("Low sugar");
        }
        else if(sugarLevel>=90 && sugarLevel<130)
        {
            System.Console.WriteLine("Normal");
        }
        else if(sugarLevel>=130 && sugarLevel<140)
        {
            System.Console.WriteLine("Medium");
        }
        else if(sugarLevel>=140 && sugarLevel<170)
        {
            System.Console.WriteLine("High Sugar.....Try to reduce it now");
        }
        else if(sugarLevel>=170)
        {
            System.Console.WriteLine("You are a very high suger patient");
        }
    }
}