using System;
using System.IO;
using System.Collections.Generic;
namespace ListFile;
class Program{
    public static void Main(string[] args)
    {
        List<StudentDetails> vlist = new List<StudentDetails>();
        vlist.Add(new StudentDetails() {Name="Sudharsan",FatherName="karthikeyan",Gender=Gender.Male,DOB=new DateTime(1111/11/11)});
        vlist.Add(new StudentDetails() {Name="Name",FatherName="fathername",Gender=Gender.Default,DOB =new DateTime(1111/11/11)});
        Insert(vlist);
        Display();
        //Update();
    }

    static void Insert(List<StudentDetails>vlist)
    {
        StreamWriter write=null;
        if(!File.Exists("Data.csv"))
        {
            System.Console.WriteLine("File not exists creating a new csv file");
            File.Create("Data.csv");
        }
        else
        {
            System.Console.WriteLine("File found");
        }
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var v in vlist)
        {
            write.WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.DOB.ToString("dd/MM/yyyy"));
        }
        write.Close();
    }
    static void Display()
    {
        StreamReader reader=null;
        List<StudentDetails> listA=new List<StudentDetails>();
        if(File.Exists("Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("Data.csv"));
            while(!reader.EndOfStream)
            {
                var lines=reader.ReadLine();
                var values=lines.Split(',');
                if(values[0]!="")
                {
                    listA.Add(new StudentDetails(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});

                }
            }
        }
        else
        {
            System.Console.WriteLine("File not exists");
        }
        reader.Close();
        foreach(var column1 in listA)
        {
            System.Console.WriteLine("Yor name: "+column1.Name);
            System.Console.WriteLine("Your father name : "+column1.FatherName);
            System.Console.WriteLine("your gender: "+column1.Gender);
            System.Console.WriteLine("your dob : "+column1.DOB);
        }
    }
    
    static void Update()
    {
        System.Console.WriteLine("To update select option 0.your name 1.father name");
        int option=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter a name to be updated");
        string name1=Console.ReadLine();
        
    }
}