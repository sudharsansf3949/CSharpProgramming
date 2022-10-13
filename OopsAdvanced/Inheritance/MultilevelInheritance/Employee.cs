using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class Employee:EmploymentDetails
    {
        private static int s_employeeId=1000;
        public string EmployeeId { get; set; }
        public DateTime RegistrationDate { get; set; }



        public Employee(string studentId,string aid,string name,string fatherName,Gender gender,long phone,Department department):base(aid, name, fatherName, gender, phone)
        {
            s_employeeId++;
            EmployeeId="EID"+s_employeeId;
            RegistrationDate=DateTime.Now;
        }
        
        public void ShowEmployee()
        {
            System.Console.WriteLine("Employment Id"+EmployeeId);
            ShowDetails();
            System.Console.WriteLine("Registration Date "+RegistrationDate.ToShortDateString());
        }
    }
}