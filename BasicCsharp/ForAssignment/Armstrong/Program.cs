using System;
namespace Armstrong;
class program{
    public static void Main(string[] args)
    {
        int num,reaminder,sum=0,temp;
        System.Console.WriteLine("Enter the number: ");
        num=Convert.ToInt32(Console.ReadLine());
        temp=num;
        while(num>0){
            reaminder=num%10;
            sum=sum+(reaminder*reaminder*reaminder);
            num=num/10;
        }
       
        if(temp==sum){
            System.Console.WriteLine("Its is Armstrong number");
        }
        else{
            System.Console.WriteLine("Its not a Armstrong number");
        }        
        
    }
}