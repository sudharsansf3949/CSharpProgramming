using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineId=100;
        public string MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medicineName,int count,int price,DateTime dateOfExpiry)
        {
            MedicineId="MID"+s_medicineId;
            MedicineName=medicineName;
            Count=count;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }

        public MedicineDetails(string data)
        {
            string[] value=data.Split(',');
            s_medicineId=int.Parse(value[0].Remove(0,3));
            MedicineId=value[0];
            MedicineName=value[1];
            Count=int.Parse(value[2]);
            Price=int.Parse(value[3]);
            DateOfExpiry=DateTime.Parse(value[4]);

        }
    }
}