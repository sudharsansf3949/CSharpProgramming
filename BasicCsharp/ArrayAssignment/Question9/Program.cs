using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter th row size of array1: ");
        int row1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the colum size of array1: ");
        int col1=int.Parse(Console.ReadLine());
        int[,] array1=new int[row1,col1];

        System.Console.WriteLine("Enter row for array2: ");
        int row2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the colum for array2: ");
        int col2=int.Parse(Console.ReadLine());
        int[,] array2=new int[row2,col2];

        int[,] product=new int[2,2];
        
        System.Console.WriteLine("Enter elemnts for array1: ");
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<col1;j++)
            {
                array1[i,j]=int.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine("Enter elements for array2: ");
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<col2;j++)
            {
                array2[i,j]=int.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine("The First Matrix is");
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<col1;j++)
            {
                System.Console.Write(array1[i,j]+"\t");
            }
            System.Console.WriteLine(" ");
        }

        System.Console.WriteLine("The second Matrix is");
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<col2;j++)
            {
                System.Console.Write(array2[i,j]+"\t");
            }
            System.Console.WriteLine(" ");
        }        

        for(int i=0;i<col1;i++)
        {
            for(int j=0;j<row2;j++)
            {
                product[i,j]=0;
                for(int k=0;k<2;k++)
                {
                    product[i,j]+=array1[i,k]*array2[k,j];
                }
            }
        }
        
        System.Console.WriteLine("The Multiplication of two matrix is");
        for(int i=0;i<col1;i++)
        {
            for(int j=0;j<row2;j++)
            {
                System.Console.Write(product[i,j]+"\t");

            }
            System.Console.WriteLine(" ");
        }
    }
}