using System;
using System.IO;

using System.Linq;
using System.Threading.Tasks;

namespace CollegeApplication
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory ("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/AdmissionDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("College/DepartmentDetails.csv");
            }

        }

        public static void ReadFile()
        {
            string [] students=File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operations.studentList.Add(student);
            }
            string []  admission=File.ReadAllLines("College/AdmissionDetails.csv");
            foreach(string data in admission)
            {
                AdmissionDetails admissions=new AdmissionDetails(data);
                Operations.admissionList.Add(admissions);
                
            }
            
            string [] department=File.ReadAllLines("College/DepartmentDetails.csv");
            foreach(string data in department)
            {
                DepartmentDetails departments =new DepartmentDetails(data);
                Operations.departmentList.Add(departments);
            }
        }

        public static void WritetoFiles()
        {
            string [] studentDetails=new string[Operations.studentList.Count];
            for(int i=0;i<Operations.studentList.Count;i++)
            {
                studentDetails[i]=Operations.studentList[i].StudentId+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].Gender+","+Operations.studentList[i].Maths+","+Operations.studentList[i].Physics+","+Operations.studentList[i].Chemistry;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);

            string[] admissionDetails=new string[Operations.admissionList.Count];
            for(int i=0;i<Operations.admissionList.Count;i++)
            {
                admissionDetails[i]=Operations.admissionList[i].AdmissionId+","+Operations.admissionList[i].DepartmentId+","+Operations.admissionList[i].StudentId+","+Operations.admissionList[i].AdmissionDate+","+Operations.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("College/AdmissionDetails.csv",admissionDetails);

            string [] departmentDetails=new string[Operations.departmentList.Count];
            for(int i=0;i<Operations.admissionList.Count;i++)
            {
                departmentDetails[i]=Operations.departmentList[i].DepartmentId+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NoofSeats;
            }
            File.WriteAllLines("College/DepartmentDetails.csv",departmentDetails);
        }
    }
}