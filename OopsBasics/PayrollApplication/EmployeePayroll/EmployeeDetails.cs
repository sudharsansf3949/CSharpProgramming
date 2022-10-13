using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public enum WorkLocation{Default,Mathura,Eymard}
    public enum Gender{Default,Male,Female,Transgender}
    public class EmployeeDetails
    {
        private static int s_employeeId=1000;
        public string EmployeeId { get; }
        
        
        public string EmployeeName { get; set; }
        public string EmployeeRoll { get; set; }
        public string TeamName { get; set; }
        public DateTime JoiningDate { get; set; }
        public Gender Gender { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public int  WorkedDays { get; set; }
        public int Leave { get; set; }
        public int Salary { get; set; }
        
        
    
        
        
        
        

        public EmployeeDetails(string name,string roll,string teamName,Gender gender,WorkLocation workLocation,int days,int leave,DateTime joiningDate)
        {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            EmployeeName=name;
            Gender=gender;
            WorkLocation=workLocation;
            EmployeeRoll=roll;
            TeamName=teamName;
            WorkLocation=workLocation;
            WorkedDays=days;
            Leave=leave;
            JoiningDate=joiningDate;
        }

        public void CalculateSalary()
        {
            int salary=0;
            int noDays=WorkedDays-Leave;
            salary=noDays*500;

            System.Console.WriteLine("The salary is: "+salary);
        }

        public void ShowDetails()
        {
            System.Console.WriteLine("Details of"+EmployeeName);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Employee Name is         : "+EmployeeName);
            System.Console.WriteLine("Employee Gender is       : "+Gender);
            System.Console.WriteLine("Employee Work location is: "+WorkLocation);
            System.Console.WriteLine("Employee Team name is    : "+TeamName);
            System.Console.WriteLine("Employee Joining date is : "+JoiningDate);
            System.Console.WriteLine("Employee Id is           : "+EmployeeId);
                       
        }  
        
    }
}