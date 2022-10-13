using System;
namespace Question4;
class program{
    public static void Main(string[] args)
    {
        int num=111,n1=0,r,sum=0;
       do{

            r=num%10;
            sum=(r*r*r);
            num=num/10;
            num++;
       
            n1=num;


            if(n1==sum){
            System.Console.WriteLine(sum);
            }
            num++;
       }while(num<1000);
       
    }
}