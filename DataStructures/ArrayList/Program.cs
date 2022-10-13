using System;
namespace ArrayList;
class program{
    public static void Main(string[] args)
    {
        ArrayList data=new ArrayList();
        data.Add(10);
        data.Add("adb");
        data.Add('c');
        data.Add(100.98);
        data.Add(333);
        data.Add(333);
        data.Add("SL");
        data.Insert(5,"KK");
        data.IndexOf('c');
       
    }
}