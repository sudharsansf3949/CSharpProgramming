using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student =new StudentInfo("Sudharsan","Karthikeyan",Gender.Male,121548976,new DateTime (11/11/111),"sudhars@mail","SAS","CSE","final");
        student.ShowStudent();
    }
}