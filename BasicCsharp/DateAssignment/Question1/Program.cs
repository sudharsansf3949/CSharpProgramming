using System;
namespace Question1;
class program{
    public static void Main(string[] args)
    {
       DateTime[] curr_date={DateTime.Now,new DateTime(2016,8,16,9,28,0),new DateTime(2011,5,28,10,35,0),new DateTime(1979,12,25,14,30,0)};
       for(int i=0;i<curr_date.Length;i++){
            System.Console.WriteLine("Day:"+curr_date[i].ToString("MM/dd/yyyy")+" Time: "+curr_date[i].ToString("HH:mm:ss:ff"));
            System.Console.WriteLine("Day:"+curr_date[i].ToString("MM/dd/yyyy")+" Time: "+curr_date[i].ToString("HH:mm tt"));
            System.Console.WriteLine("");
        } 
     }
}