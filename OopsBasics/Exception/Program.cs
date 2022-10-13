using System;
namespace Exception;
class Program{
    public static void Main(string[] args)
    {
        try
        {
        int number1,numnber2,output;
        System.Console.WriteLine("Enter number 1: ");
        number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter number 2: ");
        numnber2=int.Parse(Console.ReadLine());
        
        output=number1/numnber2;
        System.Console.WriteLine(output);

        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine("An Exception occured :"+e.Message);
            System.Console.WriteLine("An Exception occured :"+e.StackTrace);
        }
        catch(FormatException e)
        {
            System.Console.WriteLine("An Exception occured "+e.Message);
            System.Console.WriteLine("An Exception occured "+e.StackTrace);
        }
        finally
        {
            System.Console.WriteLine("All Exception handeled properly");
        }

    }
}