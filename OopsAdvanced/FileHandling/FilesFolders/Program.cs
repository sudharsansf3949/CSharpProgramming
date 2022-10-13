using System;
using System.IO;
namespace FilesFolders;
class program{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\SudharsanKarthikeyan\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath=path+"/Sudharsan";
        string filePath=path+"/newFile.txt";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found so creating folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Folder found");
        }
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File not found so creating file...");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File found");
        }

        System.Console.WriteLine("Select option 1.Create Folder 2.Create File 3.Delete Folder 4.Delete File");
        int num=int.Parse(Console.ReadLine());
        switch(num)
        {
            case 1:
            {
                System.Console.WriteLine("Enter the folder name you want to create:");
                string folderName=Console.ReadLine();
                string newPath=path+"\\"+folderName;
                if(!Directory.Exists(newPath))
                {
                    System.Console.WriteLine("Directory not found");
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    System.Console.WriteLine("Directory already exists");
                }
                break;
            }

            case 2:
            {
                System.Console.WriteLine("Enter your filename you want to create: ");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter file Extension you want to create: ");
                string extension=Console.ReadLine();
                string newPath=path+"\\"+fileName+extension;
                if(!File.Exists(newPath))
                {
                    System.Console.WriteLine("File not found create new file");
                    File.Create(newPath);
                }
                else
                {
                    System.Console.WriteLine("File Name alredy exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                        Directory.Delete(newPath);
                        System.Console.WriteLine("Folder Deleted");
                    }
                }
                break;

            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select the file you want to delete");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter file Extension you want to delete");
                string name2=Console.ReadLine();
                string newPath=path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)
                    {
                        File.Delete(newPath);
                        System.Console.WriteLine("File Deleted");
                    }
                }
                break;
            }
        }
    }
}