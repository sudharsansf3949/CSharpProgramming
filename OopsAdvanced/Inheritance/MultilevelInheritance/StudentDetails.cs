using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public enum Department{Default,CSE,EEE,ECE}
    public class StudentDetails:EmploymentDetails,IMarkDetails
    {
        private static int s_studentId=1000;
        public string StudentId { get; set;  }
        public Department Department { get; set; }
        public string Year { get; set; }
        public int Physics { get; set; }    //property declaration olny allowed
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }


        
        public StudentDetails(string aid,string name,string fatherName,Gender gender,long phone,Department department,string year):base(aid, name, fatherName, gender, phone)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;

        }


        public StudentDetails(string studentId,string aid,string name,string fatherName,Gender gender,long phone,Department department):base(aid, name, fatherName, gender, phone)
        {
            StudentId=studentId;
            Department=department;

        }

        public void ShowStudent()
        {
            System.Console.WriteLine("Your Student Id is:  "+StudentId);
            ShowDetails();
            System.Console.WriteLine("Your Department is:  "+Department);
            System.Console.WriteLine("Your Year is      :  "+Year);
        }

        public void GetMark(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }


        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;
            Average=(double)Total/3;

        }
        public void ShowMark()
        {
            System.Console.WriteLine("Your Physics mark is     : "+Physics);
            System.Console.WriteLine("Your Chemistry mark is   : "+Chemistry);
            System.Console.WriteLine("Your maths mark is       : "+Maths);
            System.Console.WriteLine("Your Total mark is       : "+Total);
            System.Console.WriteLine("Your Average is          : "+Average);

        }     
    }
}