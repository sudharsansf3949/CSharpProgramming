using System;
namespace Question5;
class program{
    public static void Main(string[] args)
    {
        int n=1,n1=2000;
        do{
            if(n%4==0){
                System.Console.Write(n +"   ");
            }
            n++;

        }while(n<=n1);
    }
}