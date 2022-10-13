using System;
namespace MultilevelInheritance;
class Program{
    public static void Main(string[] args)
    {
        EmploymentDetails person=new("Sudharsan","Karthikeyan",Gender.Male,12347);
        person.ShowDetails();

        System.Console.WriteLine(" ");

        StudentDetails student=new StudentDetails("55555","Sudharsan","Karthikeyan",Gender.Male,13423425,Department.CSE,"Final");
        student.ShowStudent();
        student.GetMark(90,90,99);
        student.Calculate();
        student.ShowMark();
        System.Console.WriteLine(" ");

        CustomerDetails customer=new CustomerDetails("5555","Sudharsan","Karthikeyan",Gender.Male,1234245);
        //customer.Recharge();
        customer.ShowCustomer();

        Employee employee=new Employee("1111","AID2222","Sudharsan","Karthikeyan",Gender.Male,111111,Department.CSE);
        employee.ShowEmployee();


    }
}