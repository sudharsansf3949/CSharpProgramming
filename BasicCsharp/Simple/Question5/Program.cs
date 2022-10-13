using System;
namespace Question5;
class program{
   public static void Main(string[] args)
   {
    double salary=10000,annualSalary=0;
    double hra=0.01,da=0.01,tax=0.05;
    annualSalary=(salary+(salary*hra)+(salary*da))-(salary*tax);
    System.Console.WriteLine("The Annual Salary is"+annualSalary);
   }
}