using System;
namespace Question7;
class program{
    public static void Main(string[] args)
    {
        int i,j;
        int[,] arr=new int[3,3];
        System.Console.WriteLine("Enter elements in matrix");
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                System.Console.WriteLine($"Element[{i}][{j}]",i,j);
                arr[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("The matrix is");
        for(i=0;i<3;i++){
            System.Console.WriteLine(" ");
            for(j=0;j<3;j++){
                System.Console.Write("\t"+arr[i,j]);
            }
            System.Console.Write(" ");
        }
    }
}

