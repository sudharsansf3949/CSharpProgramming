using System;
namespace AbstractClasses;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\nSyncfusion");
        Syuncfusion job1=new Syuncfusion();
        job1.Name="Developer";
        job1.Salary(30);

        System.Console.WriteLine("\nTCS");
        TCS job2=new TCS ();
        job2.Name="Test Engineer";
        job2.Salary(15);
    }
}