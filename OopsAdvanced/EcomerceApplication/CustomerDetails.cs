using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceApplication
{
    public class CustomerDetails
    {
        private static int s_customerId=1000;
        public String CustomerId { get;  }
        public string Name { get; set; }
        public string City { get; set; }
        public long MobileNumber { get; set; }
        public double WalletBalance { get; set; }
        public string MailId { get; set; }


        public CustomerDetails(string name,string city,long mobileNumber,double walletBalance,string mailId)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            Name=name;
            City=city;
            MobileNumber=mobileNumber;
            WalletBalance=walletBalance;
            MailId=mailId;   
        }

        public double walletRecharge(double amount)
        {
            double updateWallet=WalletBalance+amount;   
            return updateWallet;
        }
    }
}