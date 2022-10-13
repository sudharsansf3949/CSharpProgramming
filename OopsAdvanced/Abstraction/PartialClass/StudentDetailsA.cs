using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
          public StudentDetails(string aid,string name,string fatherName,Gender gender,long phone,Department department,string year)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;

        }


        public void ShowStudent()
        {
            System.Console.WriteLine("Your Student Id is:  "+StudentId);
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