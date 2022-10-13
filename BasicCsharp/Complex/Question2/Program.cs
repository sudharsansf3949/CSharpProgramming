using System;
namespace Question2;
class program{
    public static void Main(string[] args)
    {
        double i=2,ans=1,start=1,end,k=1;
        System.Console.WriteLine("Enter the number: ");
        end=double.Parse(Console.ReadLine());
        do{
            double pow=power(i,start);
            double factorial=factoria(start);
            ans=ans+(pow/factorial);    
            k++;
            start++;
        }while(k<end);
        System.Console.WriteLine(ans);
        


        double power(double val1,double val2){
            double ans=1;
            for(double j=1;j<=val2;j++){
                ans=ans*val1;
            }
            return ans;
        }

        double factoria(double val1){
            double ans=1;
            for(double i=val1;i>0;i--){
                ans=ans*i;
            }
            return ans;
        }
    }
}