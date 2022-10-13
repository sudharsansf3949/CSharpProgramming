using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Medical"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory ("Medical");
            }
            if(!File.Exists("Medical/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Medical/UserDetails.csv");
            }
            if(!File.Exists("Medical/MedicineDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Medical/MedicineDetails.csv");
            }
            if(!File.Exists("Medical/OrderDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Medical/OrderDetails.csv");
            }

        }

        public static void ReadFile()
        {
            
            string [] user=File.ReadAllLines("Medical/UserDetails.csv");
            foreach(string data in user)
            {
                UserDetails users=new UserDetails(data);
                Operations.userList.Add(users);
            }

            string []  medicine=File.ReadAllLines("Medical/MedicineDetails.csv");
            foreach(string data in medicine)
            {
                MedicineDetails medicines=new MedicineDetails(data);
                Operations.medicineList.Add(medicines);
                
            }
            
            string [] orders=File.ReadAllLines("Medical/OrderDetails.csv");
            foreach(string data in orders)
            {
                OrderDetails order =new OrderDetails(data);
                Operations.orderList.Add(order);
            }
        }

        public static void WritetoFiles()
        {
            int i;

            string [] userDetails=new string[Operations.userList.Count];
            for (i=0;i<Operations.userList.Count;i++)
            {
                userDetails[i]=Operations.userList[i].UserId+","+Operations.userList[i].UserName+","+Operations.userList[i].Age+","+Operations.userList[i].City+","+Operations.userList[i].Phone+","+Operations.userList[i].Balance;

            }
            File.WriteAllLines("Medical/UserDetails.csv",userDetails);

            string [] medicineDetails=new string [Operations.medicineList.Count];
            for(i=0;i<Operations.medicineList.Count;i++)
            {
                medicineDetails[i]=$"{Operations.medicineList[i].MedicineId},{Operations.medicineList[i].MedicineName},{Operations.medicineList[i].Count},{Operations.medicineList[i].Price},{Operations.medicineList[i].DateOfExpiry}";
            }
            File.WriteAllLines("Medical/MedicineDetails.csv",medicineDetails);

            string [] orderDetails=new string[Operations.orderList.Count];
            for(i=0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i]=$"{Operations.orderList[i].OrderId} , {Operations.orderList[i].UserId} , {Operations.orderList[i].MedicineId} , {Operations.orderList[i].Count} , {Operations.orderList[i].TotalPrice} , {Operations.orderList[i].OrderDate} , {Operations.orderList[i].OrderStatus}";
            }
            File.WriteAllLines("Medical/OrderDetails.csv",orderDetails);
        }

        
    }
}