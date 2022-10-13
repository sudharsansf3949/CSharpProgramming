using System;
namespace EnumeratedDatatype;
public enum Gender{Default,Male,Female,Transgender}
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Select gender option male,female,transgender");
        Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender1);
        System.Console.WriteLine("Select gender option male,female,transgender");
        Gender gender2=Gender.Default;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        while(!temp || !((int)gender2<4 && (int) gender2>0))
        {
            System.Console.WriteLine("Invalid gender \n Enter again");
            temp=Enum.TryParse<Gender>(Console.ReadLine(),out gender2);
        }
        System.Console.WriteLine(gender2);

    }
}