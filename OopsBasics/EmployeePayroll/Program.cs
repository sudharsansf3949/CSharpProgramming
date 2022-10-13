using System;
using System.Collections.Generic;
namespace EmployeePayroll;
class program{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> employeeList=new List<EmployeeDetails>();

        System.Console.WriteLine("Are you add another Employee yes or no");
        string choice=Console.ReadLine().ToLower();

        while(choice=="yes")
        {
            System.Console.WriteLine("Enter Employee Details");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your roll: ");
            string roll=Console.ReadLine();
            System.Console.WriteLine("Enter your Team name");
            string teamName=Console.ReadLine();
            System.Console.WriteLine("Enter Wrok Location Mathura or Eymard ");
            WorkLocation location=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your date of joining in dd/mm/yyyy");
            DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter number of days worked: ");
            int days=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number of leave taken: ");
            int leave=int.Parse(Console.ReadLine());
    

            EmployeeDetails details=new EmployeeDetails(name,roll,teamName,gender,location,days,leave,date);
            employeeList.Add(details);
            System.Console.WriteLine("Are you want to add another Employee yes or no");
            choice=Console.ReadLine().ToLower();
        }

        foreach(EmployeeDetails detail in employeeList)
        {
            System.Console.WriteLine("Details of"+detail.EmployeeName);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Employee Name is         : "+detail.EmployeeName);
            System.Console.WriteLine("Employee Gender is       : "+detail.Gender);
            System.Console.WriteLine("Employee Work location is: "+detail.WorkLocation);
            System.Console.WriteLine("Employee Team name is    : "+detail.TeamName);
            System.Console.WriteLine("Employee Joining date is : "+detail.JoiningDate);
            System.Console.WriteLine("Employee Id is           : "+detail.EmployeeId);
            detail.CalculateSalary();
        }
    }
}