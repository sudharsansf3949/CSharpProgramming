using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionLibrary
{
    public enum Gende{Default,Male,Female,Transgender}
    
    
    public class StudentDetails
    {

        
    private static int s_registerNumber=3000;
    public string RegisterNumber { get;  }
     //private string _name="sudharsan";//field declaration

     //public string Name { get{return _name;} set{_name=value;} }
     
    public string Name { get; set; } //auto property
    public string FatherName { get; set; }
    public DateTime DOB { get; set; }
    public Gende Gender { get; set; }
    public long Phone { get; set; }
    public string Mail { get; set; }
    public int Physics { get; set; }
    public int Chemistry { get; set; }
    public int Math { get; set; }
    
    public StudentDetails()   //default constructor
    {
        Name="Your name";
        FatherName="Your Father name";
    }


    //parameterized constructor
    public StudentDetails( string name,string fatherName,string mail,Gende gender,DateTime dob,long phone,int maths,int physics,int chemistry)
    {
        s_registerNumber++;
        RegisterNumber="Sf"+s_registerNumber;

        Name=name;
        FatherName=fatherName;
        Mail=mail;
        Gender=gender;
        DOB=dob;
        Phone=phone;
        Math=maths;
        Physics=physics;
        Chemistry=chemistry;

    }

    public bool CheckEligiblity(double cutOff)
    {
        double average=(double)(Physics+Chemistry+Math)/3;
        if(average>=cutOff)
        {
            return true;
        }
        else
        {
            
            return false;
        }
    }
    //destructor
    ~StudentDetails(){

    }

    }

}