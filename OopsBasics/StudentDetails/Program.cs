using System;
namespace StudentDetails;
    class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("Enter your name:");
        String stdName = Console.ReadLine();
        Console.WriteLine("Enter your Father's name: ");
        String fatherName = Console.ReadLine();
        Console.WriteLine("Enter your mail Id: ");
        String mailId = Console.ReadLine();
        Console.WriteLine("Enter your contact no: ");
        long contactNo=Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Entet your Age: ");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Gender: ");
        String gender=Console.ReadLine();

        Console.WriteLine("Enter your Maths mark out of 200: ");
        int mark1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your Physics mark out of 200: ");
        int mark2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter your Chemistry mark out of 200: ");
        int mark3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your name is       : "+stdName);
        Console.WriteLine("Your Father's is   : "+fatherName);
        Console.WriteLine("Your Mail id is    : "+mailId);
        Console.WriteLine("Your Contact no is : "+contactNo);
        Console.WriteLine("Your age is        : "+age);
        Console.WriteLine("Your Gender is     : "+gender);

        int sum = mark1+mark2+mark3;
        float avg = (float)sum/3;
        float percentage = ((float)sum/600)*100;

        Console.WriteLine("The Average of your Mark is: "+avg);
        Console.WriteLine("You got "+percentage+" %");
    }
}