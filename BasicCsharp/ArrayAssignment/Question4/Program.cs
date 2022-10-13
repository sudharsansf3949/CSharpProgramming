using System;
namespace Question4;
class program{
    public static void Main(string[] args)
    {
         int len;
        System.Console.WriteLine("Enter the number of elements ");
        len=Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[len];
        for(int i=0;i<len;i++)
        {
            System.Console.WriteLine("Enter the elements: ");
            numbers[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        int max=numbers[0],min=numbers[0];
        for(int i=0;i<len;i++)
        {
            if(numbers[i]>max)
            {
                max=numbers[i];
            }
            if(numbers[i]<min)
            {
                min=numbers[i];
            }
        }
        System.Console.WriteLine("The maximun elemengt is: "+max);
        System.Console.WriteLine("The minimum element is: "+min);
        

    }
}