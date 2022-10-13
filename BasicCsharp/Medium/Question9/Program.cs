using System;
namespace Question9;
class program{
    public static void Main(string[] args)
    {
        int num=6,space,len;
        space=num-1;
        for(int i=1;i<=num;i++){
            for(int j=1;j<=(num-i);j++){
                
                System.Console.Write(" ");
            }
            for(int star=1;star<=i;star++)
            {
                System.Console.Write("*");
            }
            for(len =(i-1);len>=1;len--)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
            
        
        }

    }
}