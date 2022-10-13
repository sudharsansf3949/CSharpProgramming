using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Gender{Default,Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Enum Gender { get; set; }  
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Mail { get; set; }
        

        public PersonalInfo(string name,string fatherName,Gender gender,long phone,DateTime dob,string mailId)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone =phone;
            DOB=dob;
            Mail=mailId;

        }

        public void ShowPersonalInfo()
        {
            System.Console.WriteLine("Your Name is: "+Name);
            System.Console.WriteLine("Your Father name is: "+FatherName);
            System.Console.WriteLine("Your Gender is: "+Gender);
            System.Console.WriteLine("Your Mobile Number is: "+Phone);
            System.Console.WriteLine("Your Date of birth is: "+DOB);
            System.Console.WriteLine("Your Mail is: "+Mail);
        }

        
    }
}