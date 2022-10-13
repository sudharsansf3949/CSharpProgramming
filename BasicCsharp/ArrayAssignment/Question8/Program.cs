using System;
namespace Question8;
class program{
    public static void Main(string[] args)
    {
        
        int n=0,i=0;
        System.Console.WriteLine("Enter the size od the square matrix less than 5: ");
        n=int.Parse(Console.ReadLine());
         int[,] arr=new int[2,2];

        while(n<2){
            System.Console.WriteLine("Enter the element in"+n+"matrix");
            if(n<0){
                for(i=0;i<2;i++){
                    for(int j=0;j<2;j++){
                        System.Console.WriteLine($"Elements of[{i}][{j}]",i,j);
                        arr[i,j]=int.Parse(Console.ReadLine());
                       
                    }
                }
            }
            n++;

        }

    }
}