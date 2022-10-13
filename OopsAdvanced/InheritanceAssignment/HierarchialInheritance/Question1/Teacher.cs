using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Teacher
    {
        public string TeacherId { get; set; }
        public string Department { get; set; }
        public string TeachingSub { get; set; }
        public string Qualification { get; set; }
        public int Expereince { get; set; }
        public DateTime JoiningDate { get; set; }

        public Teacher(string teacherId,string department,string teachingSub,string qualification,int experience,DateTime joiningDate)
        {
            Department=department;
            TeacherId=teacherId;
            TeachingSub=teachingSub;
            Expereince=experience;
            JoiningDate=joiningDate;
        }
    }
}