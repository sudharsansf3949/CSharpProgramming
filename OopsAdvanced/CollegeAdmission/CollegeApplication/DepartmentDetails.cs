using System;

using System.Linq;
using System.Threading.Tasks;

namespace CollegeApplication
{
    public class DepartmentDetails
    {
        private static int s_departmentId=101;
        public string DepartmentId { get;}
        public string DepartmentName { get; set; }
        public int NoofSeats { get; set; }


        public DepartmentDetails(string departmentId,string departmentName,int noofSeats)
        {
            s_departmentId++;
            DepartmentName=departmentName;
            DepartmentId="DID"+s_departmentId;
            NoofSeats=noofSeats;
        }

        public DepartmentDetails(string data)
        {
            string [] values=data.Split(',');
            s_departmentId =int.Parse(values[0].Remove(0,3));
            DepartmentId=values[0];
            DepartmentName=values[1];
            NoofSeats=int.Parse(values[2]);

        }

        
    }
}

