using System;
namespace Question2;
class program{
    public static void Main(string[] args)
    {
        int n1=0,n2=1,n3,num;
        System.Console.WriteLine("Enter the numbr of terms: ");
        num=int.Parse(Console.ReadLine());
        System.Console.WriteLine("The Fibonaaci series upto "+num);

        System.Console.Write(+n1+ " " +n2+" " );
        for(int i =2;i<num;i++){
            n3=n1+n2;
            System.Console.Write(n3+" ");
            n1=n2;
            n2=n3;
        }

    }
}