using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HigherInheritance

{

public enum Gender{Default,Male,Female,TransGender}
    public class EmploymentDetails
    {
        private static int s_aid=1000;
        public string AadharId { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Enum Gender { get; set; }  
        public long Phone { get; set; }

        public EmploymentDetails(string name,string fatherName,Gender gender,long phone)
        {
            s_aid++;
            AadharId="AID"+s_aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;

        }


        public EmploymentDetails(string aid,string name,string fatherName,Gender gender,long phone)
        {
            
            AadharId=aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;

        }
        

        public void ShowDetails()
        {
            System.Console.WriteLine("Your Name is         : "+Name);
            System.Console.WriteLine("your Father Name is  : "+FatherName);
            System.Console.WriteLine("Your Gender is       : "+Gender);
            System.Console.WriteLine("Your Phone number is : "+Phone);
            System.Console.WriteLine("Your Aadhar Id is    : "+AadharId);
        }

    }
}