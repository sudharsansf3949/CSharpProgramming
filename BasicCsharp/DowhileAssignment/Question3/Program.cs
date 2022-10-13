using System;
namespace Question3;
class program{
    public static void Main(string[] args)
    {
        int num=0, firstNumber=0,secondNumber=1;
        int temp=1;
        System.Console.WriteLine("Enter a number: ");
        num=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(firstNumber);
        int count=0;
        do{
            count++;
            System.Console.WriteLine(secondNumber);
            temp=firstNumber+secondNumber;
            firstNumber=secondNumber;
            secondNumber=temp;

        }while(count<num-1);
    }
}