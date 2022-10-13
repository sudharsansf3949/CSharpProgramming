using System;
using System.Collections.Generic;
using AdmissionLibrary;

namespace AdmissionApplication;

public class Operations{
    public static void MainMenu()
    {

        List<StudentDetails> studentList=new List<StudentDetails>(); 

        System.Console.WriteLine("Are you Willing to join....yes or no : ");
        string willing=Console.ReadLine().ToLower();

        while(willing=="yes"){
            
            
            System.Console.WriteLine(" Enter student details");
            System.Console.WriteLine("Enter yor Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father name: ");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter Mail Id: ");
            string mail=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender: ");
            Gende gender=Enum.Parse<Gende>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your phone number: ");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Date of Birth in format dd//mm//yyy: ");
            DateTime dob =DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your Maths mark: ");
            int math=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Physics mark: ");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Chemistry mark: ");
            int chemistry=int.Parse(Console.ReadLine());

            StudentDetails student= new StudentDetails(name,fatherName,mail,gender,dob,phone,math,physics,chemistry);//object declare.....

            studentList.Add(student);

            System.Console.WriteLine("Are you Willing to join.... yes or no:  ");
            willing=Console.ReadLine().ToLower();
        } 
        
        //print student details

        foreach(StudentDetails student in studentList){

            System.Console.WriteLine("Details of "+student.Name);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Your Name is          : "+student.Name);
            System.Console.WriteLine("Your Father Name is   : "+student.FatherName);
            System.Console.WriteLine("Your Gender is        : "+student.Gender);
            System.Console.WriteLine("Your Mail Id is       : "+student.Mail);
            System.Console.WriteLine("Your Phone Number is  : "+student.Phone);
            System.Console.WriteLine("Your Date of Birth is : "+student.DOB.ToShortDateString());
            System.Console.WriteLine("Your Physics mark is  : "+student.Physics);
            System.Console.WriteLine("Your Maths mark is    : "+student.Math);
            System.Console.WriteLine("You Chemistry mark is : "+student.Chemistry);
            System.Console.WriteLine("Your register number is: "+student.RegisterNumber);
            System.Console.WriteLine("The Eligiblity of joining the college ");
            bool eligible=student.CheckEligiblity(75.0);
            if(eligible)
            {
                System.Console.WriteLine("You are Eligible for admission");
            }
            else{
                System.Console.WriteLine("You are not Eligible for admission");
            }
            System.Console.WriteLine(" ");

        }

       
    }
    


}
    
