using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks
{
    public enum Gender{Default,Male,Female}
    public enum Department{Default,CSE,ECE,EEE}
    public class UserDetails
    {
        private static int s_registrationId=3000;
        public string RegistrationId { get; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public long MobileNumber { get; set; }
        public string MailId { get; set; }


        public UserDetails(string userId, string userName,Gender gender,Department department,long moileNumber,string mailID)
        {
            s_registrationId++;
            RegistrationId="SF"+s_registrationId;
            UserName=userName;
            Gender=gender;
            Department=department;
            MobileNumber=moileNumber;
            MailId=mailID;

        }

    }
}