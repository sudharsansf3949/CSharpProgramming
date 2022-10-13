using System;
namespace Question10;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter th row size of array1: ");
        int row=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the colum size of array1: ");
        int col=int.Parse(Console.ReadLine());
        int[,] array1=new int[row,col];
        int[,] array2=new int[row,col];

        System.Console.WriteLine("Enter elemnts for array1: ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                array1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                array2[j,i]=array1[i,j];
            }
        }
        System.Console.WriteLine("The Regular matrix is");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                System.Console.Write(array1[i,j]+" ");
            }
            System.Console.WriteLine(" ");
        }

        System.Console.WriteLine("The Transposal of matrix is");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                System.Console.Write(array2[i,j]+" ");
            }
            System.Console.WriteLine(" ");
        }

    }
}