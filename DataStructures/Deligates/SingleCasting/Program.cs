using System;
using System.Collections;
namespace SingleCasting;
public delegate int Calculator(int n);    //Can add methods having int return type & 1 integer value
class program{
    static int value=10;
    public static int AddNum(int number){value+=number ;return value;}
    public static int MultNum(int number){value*=number;return value;}
    public static int GetNum(){return value;}
    public static void Main(string[] args)
    {
        //create deligate instances     creating objects
        Calculator nc1=new Calculator(AddNum);
        Calculator nc2=new Calculator(MultNum);

        //calling objects using deligate objects
        nc1(25);
        System.Console.WriteLine("Value of Number : "+GetNum());
        nc2(5);
        System.Console.WriteLine("Value of Number : "+GetNum());
    }
}