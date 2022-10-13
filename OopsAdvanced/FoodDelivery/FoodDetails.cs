using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class FoodDetails
    {
        public string FoodId { get; set; }
        public string FoodName { get; set; }
        public int Price { get; set; }

        public FoodDetails(string foodId,string foodName,int price)
        {
            FoodId=foodId;
            FoodName=foodName;
            Price=price;
        }

         public FoodDetails(string Data)
        {
           string [] value=Data.Split(',');
           FoodId=value[0];
           FoodName=value[1];
           Price=int.Parse(value[2]);
        }
    }
}