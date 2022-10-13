using System;
namespace HigherInheritance;
class Program{
    public static void Main(string[] args)
    {
        EmploymentDetails person=new("Sudharsan","Karthikeyan",Gender.Male,12347);
        person.ShowDetails();

        System.Console.WriteLine(" ");

        StudentDetails student=new StudentDetails("55555","Sudharsan","Karthikeyan",Gender.Male,13423425,Department.CSE,"Final");
        student.ShowStudent();
        System.Console.WriteLine(" ");

        CustomerDetails customer=new CustomerDetails("5555","Sudharsan","Karthikeyan",Gender.Male,1234245);
        customer.Recharge();
        customer.ShowCustomer();

    }
}