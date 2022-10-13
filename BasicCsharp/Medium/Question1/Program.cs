using System;
namespace Question1;
class program{
    public static void Main(string[] args)
    {
        double basicSalary=0,annualSalary=0,takeHome=0;
        System.Console.WriteLine("Enter a salary: ");
        basicSalary=double.Parse(Console.ReadLine());

        if(basicSalary<=10000){
            annualSalary=basicSalary+(basicSalary*0.2)+(basicSalary*0.8);
            takeHome=annualSalary-(annualSalary*0.06)-(annualSalary*0.01);
            System.Console.WriteLine("The Annual slary is: "+annualSalary);
            System.Console.WriteLine("The Take home is: "+takeHome);
        }

        if(basicSalary>10000 && basicSalary<=20000){
            annualSalary=basicSalary+(basicSalary*0.25)+(basicSalary*0.9);
            takeHome=annualSalary-(annualSalary*0.06)-(annualSalary*0.01);
            System.Console.WriteLine("The annual salary is: "+annualSalary);
            System.Console.WriteLine("The Take home is: "+takeHome);
        }
        
        if(basicSalary>20000){
            annualSalary=basicSalary+(basicSalary*0.3)+(basicSalary*0.95);
            takeHome=annualSalary-(annualSalary*0.06)-(annualSalary*0.01);
            System.Console.WriteLine("The annual salary is: "+annualSalary);
            System.Console.WriteLine("The Take home is: "+takeHome);
        }
    }
}