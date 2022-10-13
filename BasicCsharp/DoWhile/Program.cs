using System;
namespace DoWhile;
class program
{
    public static void Main(string[] args)
    {

        int num ;
        String val;
        
        do
        {
            System.Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                System.Console.WriteLine("Its Even number ");
            }
            else
            {
                System.Console.WriteLine("Its odd number" );
            }
            System.Console.WriteLine("Check with another option Yes or No");
            val=Console.ReadLine().ToLower();
            while(val == "yes" && val== "no")
            {
                System.Console.WriteLine("Invalid format");
                val=Console.ReadLine().ToLower();
                
            }
        }while(val=="yes");
        
    }
   
}