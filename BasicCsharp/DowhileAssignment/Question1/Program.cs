using System;
namespace Question1;
class program{
    public static void Main(string[] args)
    {string value;
        do
        {
            int number;
            
            System.Console.WriteLine("Enter a number: ");
            number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                System.Console.WriteLine("Its even");
            }
            else{
                System.Console.WriteLine("Its odd");
            }
            System.Console.WriteLine("Did you want to continue Yes or No");
            value= Console.ReadLine().ToLower();
            
        }while(value=="yes");
    }
}