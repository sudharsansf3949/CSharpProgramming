using System;
namespace Question6;
class program{
    public static void Main(string[] args)
    {
        string str;
        System.Console.WriteLine("Enter password: ");
        str=Console.ReadLine();
        if(str=="s3cr3t!P@ssw0rd"){
            System.Console.WriteLine("Welcome");

        }
        else{
            System.Console.WriteLine("Wrong Password!");
        }
    }
}