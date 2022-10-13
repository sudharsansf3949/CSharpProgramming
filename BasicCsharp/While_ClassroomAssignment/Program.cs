using System;
namespace While_ClassroomAssignment;
class program
{
    public static void Main(string[] args)
    {
        int i=1;
        while(i<=25)
        {
            if(i%2 == 0)
            {
                System.Console.WriteLine(i);
            }
            i++;
        }
        
        int num ;
        System.Console.WriteLine("Enter the number ");
        bool temp =int.TryParse(Console.ReadLine(),out num);

        while(!temp)
        {
            System.Console.WriteLine("Invalid number format.Please enter the input in number format");
            temp=int.TryParse(Console.ReadLine(),out num);
           
        }    
        System.Console.WriteLine("Input is in correct Format: ");
        System.Console.WriteLine("The number is: "+num);
    }
}