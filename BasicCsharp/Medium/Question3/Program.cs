using System;
namespace Question3;
class program{
    public static void Main(string[] args)
    {
        int num,duplicate=0,temp=0,n1;
        System.Console.WriteLine("Enter a number: ");
        num=int.Parse(Console.ReadLine());
        n1=num;

        while(num>0){
            temp=num%10;
            duplicate =(duplicate*10)+temp;
            num=num/10;
        }
        
        if(n1==duplicate)
        {
            System.Console.WriteLine("It is palindrome");
        }
        else{
            System.Console.WriteLine("It is not palindrome");
        }
       

    }
}