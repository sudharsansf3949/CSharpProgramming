using System;
using System.IO;

using System.Linq;
using System.Threading.Tasks;

namespace CollegeApplication
{
    public enum AdmissionStatus{Default,Booked,Cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionId=1000;
        public string AdmissionId { get;}
       public string DepartmentId { get; set; }
       public string StudentId{get; set;}
       public DateTime AdmissionDate { get; set; }
       public AdmissionStatus AdmissionStatus { get; set; }  


       public AdmissionDetails(string departmentId,DateTime admissionDate,AdmissionStatus admissionStatus,string studentId,string admissionId)
       {
        s_admissionId++;
        AdmissionId="AID"+s_admissionId;
        StudentId=studentId;
        DepartmentId=departmentId;
        AdmissionDate=admissionDate;
        AdmissionStatus=admissionStatus;  

       }
       
       public AdmissionDetails(string data)
        {
            string [] values=data.Split(',');
            s_admissionId =int.Parse(values[0].Remove(0,3));
            StudentId=values[1];
            DepartmentId=values[2];
            AdmissionDate=DateTime.Parse(values[3]);
            AdmissionStatus=Enum.Parse<AdmissionStatus>(values[4]);
        }
        
    }
}