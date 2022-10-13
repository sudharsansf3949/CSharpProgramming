using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Principal
    {
        public string PrincipalId { get; set; }
        public int Qualification { get; set; }
        public int Experience { get; set; }
        public DateTime JoiningDate { get; set; }

        public Principal(string principalId,int qualification,int experience,DateTime joiningDate)
        {
            PrincipalId=principalId;
            Qualification=qualification;
            Experience=experience;
            JoiningDate=joiningDate;
        }

        public void ShowPrincipal()
        {
            System.Console.WriteLine("Principal Id is: "+PrincipalId);
            System.Console.WriteLine("Qualification is: "+Qualification);
            System.Console.WriteLine("Experience is: "+Experience);
            System.Console.WriteLine("Joining Date is: "+JoiningDate);
        }
    }
}