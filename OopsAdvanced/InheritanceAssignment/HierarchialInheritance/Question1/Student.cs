using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Student:PersonalInfo
    {
        public string  StudentId { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }

        public Student(string studentId,string degree,string department,int semester,string name,string fatherName,Gender gender,long phone,DateTime dob,string mailId):base( name, fatherName, gender, phone, dob, mailId)
        {
            StudentId=studentId;
            Degree=degree;
            Department=department;
            Semester=semester;
        }

        public void ShowStudent()
        {
            ShowPersonalInfo();
            System.Console.WriteLine("");
        }
    }
}