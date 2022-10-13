using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userId=1000;
        public string  UserId { get; set; }
        public double WalletBalance { get; set; }

        public UserDetails(string name,int age,long phoneNumber,double walletBalance):base(name, age, phoneNumber)
        {
            s_userId++;
            UserId="UID"+s_userId;
            WalletBalance=walletBalance;
        }

        public UserDetails(string data)
        {
            string[] value=data.Split(',');
            s_userId=int.Parse(value[0].Remove(0,3));
            UserId=value[0];
            Name=value[1];
            Age=int.Parse(value[2]);
            PhoneNumber=long.Parse(value[3]);
            WalletBalance=double.Parse(value[4]);
        }

        public double RechargeWallet(double amount)
        {
            WalletBalance+=amount;
            return WalletBalance;
        }

        

    }
}