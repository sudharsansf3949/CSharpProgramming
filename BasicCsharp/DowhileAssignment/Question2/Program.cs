using System;
namespace Question2;
class program{
    public static void Main(string[] args)
    {
        uint number,sum=0;
        bool temp;
        do{
            System.Console.WriteLine("Enter a number: ");
            temp=uint.TryParse(Console.ReadLine(),out number);
            sum=sum+number;
            
        }while(temp==true);
        System.Console.WriteLine("The sum is: "+sum);
    }
}