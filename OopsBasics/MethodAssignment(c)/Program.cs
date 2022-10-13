using System;
namespace Program;
class program{
    public static void Main(string[] args)
    {
        string opt;
        do{
            int num1,num2,choice;
            
            System.Console.WriteLine("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter num2: ");
            num2=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter your choice.... 1.Addition, 2.Subraction, 3.Multiplication, 4.Division");
            choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine("The Addition of given value is: "+Addition(num1,num2));
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("The Subraction of given value is: "+Subraction(num1,num2));
                    break;
                }
                case 3:
                {
                   
                    System.Console.WriteLine("The Multiplication of given value is: "+Multiplication(num1,num2));
                    break;
                }
                case 4:
                {
                   System.Console.WriteLine(("The Division of given value is: "+Division(num1,num2)));
                   break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid input.....Enter input in number format");
                    break;
                }
            }
            System.Console.WriteLine("Do you want to repeat yes or no: ");
            opt=Console.ReadLine().ToLower();   
        }while(opt=="yes");

        int Addition(int num1,int num2)
        {
            int sum=num1+num2;
            return sum;
        }
        int Subraction(int num1,int num2)
        {
            int sub=num1-num2;
            return sub;
        }
        int Multiplication(int num1,int num2)
        {
            int mul=num1*num2;
            return mul;
        }
        int Division(int num1,int num2)
        {
            int div=num1/num2;
            return div;
        }
    }
}