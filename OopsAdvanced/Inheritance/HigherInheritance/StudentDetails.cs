using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HigherInheritance
{
    public enum Department{Default,CSE,EEE,ECE}
    public class StudentDetails:EmploymentDetails
    {
        private static int s_studentId=1000;
        public string StudentId { get; set;  }
        public Department Department { get; set; }
        public string Year { get; set; }

        
        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phone,Department department,string year):base(aid, name, fatherName, gender, phone)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;

        }


        public void ShowStudent()
        {
            System.Console.WriteLine("Your Student Id is:  "+StudentId);
            ShowDetails();
            System.Console.WriteLine("Your Department is:  "+Department);
            System.Console.WriteLine("Your Year is      :  "+Year);
        }
    }
}