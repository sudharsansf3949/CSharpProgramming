using System;
namespace Question4;
class program{
    public static void Main(string[] args)
    {
        int num,i=1;
        while(i>0)
        {
            System.Console.WriteLine("Enter the number: ");
            bool temp=int.TryParse(Console.ReadLine(),out num);
            if(temp==false)
            {
                System.Console.WriteLine("Invalid input enter again...");
            }
            if(num>0&&num<=5)
            {
                System.Console.WriteLine("Valid input");
            }
            else
            {
                System.Console.WriteLine("Invalid input5");
            }

        }
        
        
    }
}