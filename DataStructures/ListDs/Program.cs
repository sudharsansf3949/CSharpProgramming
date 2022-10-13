using System;
namespace ListDs;
class Program{
    public static void Main(string[] args)
    {
        List<int> data=new List<int>();
        data.AddElement(10);
        data.AddElement(22);
        data.AddElement(22);
        data.AddElement(88);
        data.AddElement(23);
        data.AddElement(66);
        //data.Insert(3,50);
        //data.RemoveAt(2);
        //data.Remove(88);
        foreach(var val in data)
        {
            System.Console.Write(val+"\t");
        }
        System.Console.WriteLine("");

        for(int i=0;i<data.Count;i++)
        {
            System.Console.Write(data[i]+"\t");
        }
    }
}