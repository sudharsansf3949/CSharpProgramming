using System;
namespace Question8
{
    class program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter date1 dd/MM/yyyy");
            DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter date2 dd/MM/yyyy");
            DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            int val=DateTime.Compare(date1,date2);
            if(val>0)
            {
                System.Console.WriteLine($"{val}: {date1} is later than {date2} ");
            }
            else if(val<0)
            {
                System.Console.WriteLine($"{val}: {date1} is earlier than {date2} ");

            }
            else
            {
                System.Console.WriteLine($"{val}: same date");
            }
        }
    }
}