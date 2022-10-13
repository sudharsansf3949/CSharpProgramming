using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class UserDetails
    {
        private static int s_userId=1000;
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long Phone { get; set; }
        public double Balance { get; set; }

        public UserDetails(string userName,int age,string city,long phone,double balance)
        {
            s_userId++;
            UserId="UID"+s_userId;
            UserName=userName;
            Age=age;
            City=city;
            Phone=phone;
            Balance=balance;
        }

        public UserDetails(string Data)
        {
            string [] values=Data.Split(',');
            s_userId=int.Parse(values[0].Remove(0,3));
            UserId=values[0];
            UserName=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            Phone=long.Parse(values[4]);
            Balance=int.Parse(values[5]);
        }

    }
}