using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public enum BloodGroup{Default,A_positive,B_positive,O_positive,AB_positive}
    public class  UserRegistration
    {
        private static int s_donorId=1000;
        public string DonorId { get; }
        public string DonorName { get; set; }
        public long MobileNumber { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public int Age { get; set; }
        public DateTime LastDonation { get; set; }


        public UserRegistration(string donorName,long mobileNumber,BloodGroup bloodGroup,int age,DateTime lastDonation)
        {
            s_donorId++;
            DonorId="DID"+s_donorId;
            DonorName=donorName;
            MobileNumber=mobileNumber;
            BloodGroup-=bloodGroup;
            Age=age;
            LastDonation=lastDonation;
        }


        public bool NextEligiblity(DateTime lastDonation)
        {
            DateTime date=lastDonation.AddDays(60);
            if(lastDonation <= date) 
            {
                return true;
            }
            else 
            {
                return false;
            }
           
        }
    }

}