using System;
using System.IO;
namespace ReadWrite;
class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder Created");
        }
        else
        {
            System.Console.WriteLine("Folder exists");
        }

        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File creates");
        }
        else
        {
            System.Console.WriteLine("File Found");
        }
        System.Console.WriteLine("Select option 1.Read file info 2.Write file info");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader sr=null;
                try
                {
                    sr =new StreamReader("TestFolder/Test.txt");
                    line=sr.ReadLine();
                    while(line!=null)
                    {
                        System.Console.WriteLine(line);
                        line =sr.ReadLine();
                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception: "+e.Message);
                }
                finally
                {
                    if(sr!=null)
                    {
                        sr.Close();
                    }
                }
                break;
            }
            case 2:
            {
                StreamWriter sw=null;
                try
                {
                    string [] old=File.ReadAllLines("TestFolder/Test.txt");
                    sw=new StreamWriter("TestFolder/Test.txt");
                    System.Console.WriteLine("Enter a new text to be palced: ");
                    string info=Console.ReadLine();
                    string old1="";
                    foreach(string text in old)
                    {
                        old1=old1+"\n"+text;
                    }
                    old1=old1+"\n"+info;
                    sw.WriteLine(old1);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception: "+e.Message);
                }
                finally
                {
                    if(sw!=null)
                    {
                        System.Console.WriteLine("Executing finally block");
                        sw.Close();
                    }
                }
                break;
            }
        }
    }

}
    