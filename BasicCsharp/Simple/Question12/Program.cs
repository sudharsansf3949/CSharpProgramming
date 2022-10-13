using System;
namespace Question12;
class program{
    public static void Main(string[] args)
    {
        int i,sum=0;
        for(i=0;i<100;i++){
            if(i%2!=0){
                sum=sum+(i*i);
            }
        }
        System.Console.WriteLine(sum);
    }
}