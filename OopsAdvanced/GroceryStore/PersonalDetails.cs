using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public enum Gender{Default,male,female,transgender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DOB { get; set; }
        public string MailId { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,long mobilenumber,DateTime dob,string mailId)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobilenumber;
            DOB=dob;
            MailId=mailId;
        }

        public PersonalDetails()
        {
                    
        }

        public void ShowPerson()
        {
            System.Console.WriteLine("Your Name is: "+Name);
            System.Console.WriteLine("Your Father name is: "+FatherName);
            System.Console.WriteLine("Your Gender is: "+Gender);
            System.Console.WriteLine("Your Mobile Number is : "+MobileNumber);
            System.Console.WriteLine("Your Date of Birth is: "+DOB);
            System.Console.WriteLine("Your MailId is: "+MailId);
        }



        
    }
}