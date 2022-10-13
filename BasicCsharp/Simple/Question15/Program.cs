using System;
namespace Question15;
class program{
    public static void Main(string[] args)
    {
        int num,count=0;
        System.Console.WriteLine("Enter a number: ");
        num=int.Parse(Console.ReadLine());
        for(int i=2;i<num/2;i++){
            if(num%i!=0){
                count=1;
            }
        }
        if(count==0){
            System.Console.WriteLine("It is prime");
        }else{
            System.Console.WriteLine("it is not prime");
        }
    }
}