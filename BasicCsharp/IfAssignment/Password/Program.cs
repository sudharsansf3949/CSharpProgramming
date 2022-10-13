using System;
namespace Password;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the password");
        String password=Console.ReadLine();
        if(password=="HiTeam")
        {
            System.Console.WriteLine("Its a correct password");
        }
        else
        {
            System.Console.WriteLine("Its a Wrong password");
        }
    }
}