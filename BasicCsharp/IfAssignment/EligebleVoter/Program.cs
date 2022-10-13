using System;
namespace EligebleVoter;
class program{
    public static void Main(string[] args)
    {
        int val;
        System.Console.WriteLine("Enter your age: ");
        val= Convert.ToInt32(Console.ReadLine());
        if(val>=18)
        {
            System.Console.WriteLine("Congratulation");
            System.Console.WriteLine("You are eligeble for voting");
        }
        else
        {
            System.Console.WriteLine("You are not eligeble for voting");

        }
        
    }
}