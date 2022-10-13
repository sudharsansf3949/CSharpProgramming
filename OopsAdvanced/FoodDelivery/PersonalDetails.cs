using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string MailId { get; set; }
        public string Location { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailId,string location)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailId=mailId;
            Location=location;
        }

        public PersonalDetails()
        {
           
        }

        public void ShowDetails()
        {
            System.Console.WriteLine("Your Name is         : "+Name);
            System.Console.WriteLine("Your Fathe Name is   : "+FatherName);
            System.Console.WriteLine("Your Gender is       : "+Gender);
            System.Console.WriteLine("Your Mobile Number is: "+Mobile);
            System.Console.WriteLine("Your Date Of Birth is: "+DOB);
            System.Console.WriteLine("You Mail Id is       : "+MailId);
            System.Console.WriteLine("Your Location is     : "+Location);
        }




    }
}