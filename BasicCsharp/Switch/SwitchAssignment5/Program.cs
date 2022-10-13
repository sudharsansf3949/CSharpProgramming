using System;
namespace SwitchAssignment5;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter team name india,pakistan,bangladesh");
        String choice=Console.ReadLine();
        switch(choice)
        {
            case "india":
            {
                System.Console.WriteLine("Dhoni");
                System.Console.WriteLine("Rohit");
                System.Console.WriteLine("Ashwin");
                System.Console.WriteLine("Jadeja");
                break;
            }
            case "pakistan":
            {
                System.Console.WriteLine("Mohamad Rizwan");
                System.Console.WriteLine("Barbar Azam");
                System.Console.WriteLine("Shadab kahn");
                System.Console.WriteLine("shaheen Afridi");
                break;
            }
            case "bangladesh":
            {
                System.Console.WriteLine("T Iqbal");
                System.Console.WriteLine("S Islam");
                System.Console.WriteLine("T Ahmed");
                System.Console.WriteLine("Shaib Al Hasan");
                break;
            }
        }
    }
}