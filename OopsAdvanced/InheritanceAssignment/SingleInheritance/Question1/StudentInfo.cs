using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber { get; set; }  
        public string Standarad  { get; set; }
        public string Branch { get; set; }
        public string AcademicYear { get; set; }


        public StudentInfo(string name,string fatherName,Gender gender,long phone,DateTime dob,string mailId,string standarad,string branch,string academicYear):base( name, fatherName, gender, phone, dob, mailId)
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Standarad=standarad;
            Branch=branch;
            AcademicYear=academicYear;
        }

        public void ShowStudent()
        {
            ShowDetaials();
            System.Console.WriteLine("Your Register Number is       : "+RegisterNumber);
            System.Console.WriteLine("Your Standarad is             : "+Standarad);
            System.Console.WriteLine("Your Branch is                : "+Branch);
            System.Console.WriteLine("Your Academic Year is         : "+AcademicYear);
        }


    }
}