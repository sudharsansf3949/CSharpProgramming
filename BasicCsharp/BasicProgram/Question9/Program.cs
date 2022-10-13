using System;
namespace Question9;
class program
{
    public static void Main(string[] args)
    {
        int speed, time, distanceTravelled;
        System.Console.WriteLine("Enter the speed : ");
        speed=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the time req: ");
        time=Convert.ToInt32(Console.ReadLine());
        distanceTravelled = speed*time*5/18;
        System.Console.WriteLine("The distance travelled is: "+distanceTravelled);
        
        
    }
}