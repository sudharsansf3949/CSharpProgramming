using System;
namespace Question10;
class progam{
    public static void Main(string[] args)
    {
        string useName,password;
        int l1,l2;
        System.Console.WriteLine("Enter a user name: ");
        useName=Console.ReadLine();
        l1=useName.Length;
        System.Console.WriteLine("Enter password: ");
        password=Console.ReadLine();
        l2=password.Length;
        if(l1>0&&l2>0)
        {
            System.Console.WriteLine("Password created successfully");
        }
    }
}