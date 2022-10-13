using System;
namespace Question1;
class program{
    public static void Main(string[] args)
    {
        int[,] arr1=new int[3,2];
        int[,] arr2=new int[2,3];
        int[,] arr3=new int[2,2];

        System.Console.WriteLine("Enter elements in array 1");
        for(int i=0;i<3;i++){
            for(int j=0;j<2;j++){
                System.Console.WriteLine($"Enter element for {i}{j}");
                arr1[i,j]=int.Parse(Console.ReadLine());
            }
            
        }

        System.Console.WriteLine("Enter elements in array 2");
        for(int i=0;i<2;i++){
            for(int j=0;j<3;j++){
                System.Console.WriteLine($"Enter the element for{i}{j}");
                arr2[i,j]=int.Parse(Console.ReadLine());
            }
        }

        for(int i=0;i<2;i++){
            for(int j=0;j<2;j++){
                arr3[i,j]= (arr1[i,j]*arr2[i,j])+(arr1[i,j+1]*arr2[i+1,j]);
            }
        }

        for(int i=0;i<2;i++){
            System.Console.WriteLine(" ");
            for(int j=0;j<2;j++){
                System.Console.Write(arr3[i,j]+" ");
            }
        }

    }
}