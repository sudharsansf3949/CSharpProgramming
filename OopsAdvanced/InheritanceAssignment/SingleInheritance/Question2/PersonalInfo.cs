using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }  
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public string MailId { get; set; }



        public PersonalInfo(string name,string fatherName,Gender gender,long phone,DateTime dob,string mailId)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
            DOB=dob;
            MailId=mailId;
        }


        public void ShowDetaials()
        {
            System.Console.WriteLine("Your Name is             : "+Name);
            System.Console.WriteLine("Your Father Name is      : "+FatherName);
            System.Console.WriteLine("Your Gender is           : "+Gender);
            System.Console.WriteLine("Your Phone Number is     : "+Phone);
            System.Console.WriteLine("Your Mail Id is          : "+MailId);
        }

    }
}