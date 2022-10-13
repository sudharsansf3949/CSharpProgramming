using System;
using System.Linq;
namespace Question13;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a string: ");
        string str=Console.ReadLine();
        int sum=0;
        for(int i=0;i<str.Length;i++)
        {
            if(char.IsDigit(str[i]))
            {
                int val=(int)char.GetNumericValue(str[i]);
                sum=sum+val;
            }
        }
        System.Console.WriteLine(sum);
    }
}