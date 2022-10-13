using System;
namespace PersonalDetails;
class Program{
    public static void Main(string[] args)
    {
        EmploymentDetails person=new("Sudharsan","Karthikeyan",Gender.Male,12347);
        person.ShowDetails();
    }
}