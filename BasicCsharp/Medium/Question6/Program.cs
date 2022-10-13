using System;
namespace Question6;
class program{
    public static void Main(string[] args)
    {
        int i,j;
        int[,] arr1 =new int[3,3];
        int[,] arr2=new int[3,3];
        int[,] arr3=new int[3,3];
       
        System.Console.WriteLine("\nEnter elements for array 1");
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){  
                System.Console.WriteLine($"Enter element for{i}{j}");
                arr1[i,j]=int.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine("\nEnter elements for array2");
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){
                System.Console.WriteLine($"Enter element for {i}{j}");
                arr2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("\nElements of 1st matrix");
        for(i=0;i<3;i++){
            for(j=0;j<3;j++){  
                System.Console.Write(arr1[i,j]+"\t");
            }
            System.Console.WriteLine("");
        }
        System.Console.WriteLine("\nElements of 2nd matrix");
        for(i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
                System.Console.Write(arr2[i,j]+"\t");
            }
            System.Console.WriteLine("");
        }

        for(i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
                arr3[i,j]=arr1[i,j]+arr2[i,j];
            }
        }

        System.Console.WriteLine("\nThe addition of matrix is");
        for(i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
                System.Console.Write(arr3[i,j]+"\t");
            }
            System.Console.WriteLine("");
        }


    }
}