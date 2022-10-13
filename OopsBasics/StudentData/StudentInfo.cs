using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData
{
    public static class StudentInfo
    {
        public static string Name { get; set; } //property
        
        public static string RegisterNumber;    //field

        static StudentInfo()                 //constructor
        {
            RegisterNumber="SF3949";
            Name="sudharsan";

        } 

        public static void Display()              //method
        {
            System.Console.WriteLine(RegisterNumber);
            System.Console.WriteLine(Name);
        }               
        
        
        
    }
}