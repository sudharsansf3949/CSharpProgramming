using System;
namespace MovieTicket;
class Program{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        Operations.MainMenu();
        Files.WriteFile();
    }
}