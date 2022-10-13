using System;
class program{
    static double Sum(int a,int b){return a+b;}
    static double Subract(int a ,int b){return a-b;}
        //deligate method with function deligate
    static double Calculator(Func <int,int,double> operation,int x,int y)
    {                             //a  //b //return type//nc 
        return operation(x,y);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine(Calculator(Sum,10,20));
        System.Console.WriteLine(Calculator(Subract,20,10));
    }
}