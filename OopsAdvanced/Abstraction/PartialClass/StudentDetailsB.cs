using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
         private static int s_studentId=1000;
        public string StudentId { get; set;  }
        public Department Department { get; set; }
        public string Year { get; set; }
        public int Physics { get; set; }    //property declaration olny allowed
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }


        
      
        
    }
}