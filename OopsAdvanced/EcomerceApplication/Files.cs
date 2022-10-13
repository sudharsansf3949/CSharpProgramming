using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceApplication
{
    public static class Files
    {
         public static void Create()
        {
            if(!Directory.Exists("Ecomerce"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory ("Ecomerce");
            }
            if(!File.Exists("Ecomerce/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Ecomerce/CustomerDetails.csv");
            }
            string line;
            StreamReader sr=null;
            try
            {
                sr=new StreamReader("Ecomerece/CustomerDetails.csv");
                line=sr.ReadLine();
                while(line!=null)
                {
                    System.Console.WriteLine(line);
                    line=sr.ReadLine();
                }
            }
            catch(Exception e)
            {
                System.Console.WriteLine("Exception : "+e.Message);
            }
            finally
            {
                if(sr!=null)
                {
                    sr.Close();
                }
            }
                    
                
        }

    }
}