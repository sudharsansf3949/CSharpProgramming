using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBill
{
    public class BillDetails
    {
        private int s_meterId=1001;
        public string MeterId { get; }
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailId { get; set; }
        public double UnitsUsed { get; set; }
        
        


        public BillDetails(string name,string mailId,long phoneNumber,double units)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=name;
            PhoneNumber=phoneNumber;
            MailId=mailId;
            UnitsUsed=units;
        }

        public void CalculateAmount(double unit)
        {
            double bill=0;
            if(unit<100)
            {
                System.Console.WriteLine("Free for you!...");
            }
            else if(unit>=100&&unit<200)
            {
                bill=unit*3;
                System.Console.WriteLine("The bill amount for you is: "+bill);
            }
            else if(unit>=200&&unit<400)
            {
                bill=unit*5;
                System.Console.WriteLine("The bill amount for you is: "+bill);
            }
            else if(unit>=400)
            {
                bill=unit*6;
                System.Console.WriteLine("The bill amount for you is: "+bill);
            }
        }
        public void ShowDetails()
        {
        System.Console.WriteLine("Details of              : "+UserName);
        System.Console.WriteLine("  ");
        System.Console.WriteLine("Name of the user         : "+UserName);
        System.Console.WriteLine("Phone number of user     : "+PhoneNumber);
        System.Console.WriteLine("Mail id of the User      : "+MailId);
        System.Console.WriteLine("Units used by the user   : "+UnitsUsed);
  
        }            
    }
    
}

