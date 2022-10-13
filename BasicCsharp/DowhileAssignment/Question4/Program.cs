using System;
namespace Question4;
class program{
    public static void Main(string[] args)
    {
        bool temp,count=false;
        
        do{
            int number;
            System.Console.WriteLine("Enter a number: ");
            temp=int.TryParse(Console.ReadLine(),out number);
            if(number>0&&number<=10){
                System.Console.WriteLine(number);
                count=true;
            }
            
            
        }while( temp==false || count==false);
    }
}