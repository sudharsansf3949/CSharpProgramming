using System;
namespace MedicalStore;
class program{
    public static void Main(string[] args)
    {
        Files.ReadFile();
        Operations.MainMenu();
        Files.WritetoFiles();
    }
}