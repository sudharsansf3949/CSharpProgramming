using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HigherInheritance
{
    public class CustomerDetails:EmploymentDetails
    {
        private static int s_customerId=1000;
        public string CustomerId { get; set; }
        public double Balance { get; set; }

        public CustomerDetails(string aid,string name,string fatherName,Gender gender,long phone):base(aid, name, fatherName, gender, phone)
        {
            s_customerId++;
            CustomerId="CID"+CustomerId;
        }
        public void Recharge()
        {
            System.Console.WriteLine("Enter amount to recharge: ");
            Balance+=double.Parse(Console.ReadLine());

        }
        public void ShowCustomer()
        {
            System.Console.WriteLine("Your Customer Id is "+CustomerId);
            ShowDetails();
            System.Console.WriteLine("Your Balance is"+Balance);
        }
    }
}