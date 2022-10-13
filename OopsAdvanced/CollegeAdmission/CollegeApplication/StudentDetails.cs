using System;
using System.IO;
namespace CollegeApplication
{

    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_studentId=3000;
        public string StudentId{get; set;}
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }

        public StudentDetails(string studentName,string fatherName,DateTime dob,Gender gender, int physics,int chemistry,int maths)
        {

            s_studentId++;
            StudentId="SF"+s_studentId;
            StudentName=studentName;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;

        }
        public StudentDetails(string Data)
        {
            string[] values=Data.Split(',');
            s_studentId=int.Parse(values[0].Remove(0,2));
            StudentId=values[0];
            StudentName=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            Physics=int.Parse(values[4]);
            Chemistry=int.Parse(values[5]);
            Maths=int.Parse(values[6]);
        }
        
        public bool CheckEligiblity(double cutOff)
        {
            double average=(double)(Physics+Chemistry+Maths)/3;
            if(average>=cutOff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Details of "+StudentName);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Your Name is          : "+StudentName);
            System.Console.WriteLine("Your Father Name is   : "+FatherName);
            System.Console.WriteLine("Your Date of Birth is : "+DOB);
            System.Console.WriteLine("Your Gender is        : "+Gender);
            System.Console.WriteLine("Your Physics mark is  : "+Physics);
            System.Console.WriteLine("Your Chemistry mark is: "+Chemistry);
            System.Console.WriteLine("Your Maths mark is    : "+Maths);
            System.Console.WriteLine("Your Login id is      : "+StudentId);
            
        }
    }
}