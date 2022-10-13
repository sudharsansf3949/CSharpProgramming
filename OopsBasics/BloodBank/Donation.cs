using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Donation
    {
        private static int s_donationId=1;
        public string DonationId { get; }
        public string DonorId { get; set; }
        public DateTime DonationDate { get; set; }
        public double Weight { get; set; }
        public double BloodPressure { get; set; }
        public double HaemoglobinCount { get; set; }


        public Donation(string donorId,DateTime donationDate,double weight,double bloodPressure,double haemeglobinCoount)
        {
            s_donationId++;
            DonationId="ID"+s_donationId;
            DonorId=donorId;
            DonationDate=donationDate;
            Weight=weight;
            BloodPressure=bloodPressure;
            HaemoglobinCount=haemeglobinCoount;
        }
    }
}