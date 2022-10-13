using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public class ProductDetails
    {
        private static int s_productId=100;
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }


        public ProductDetails(string productName,int quantityAvailabe,double pricePerQuantity)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            QuantityAvailable=quantityAvailabe;
            PricePerQuantity=pricePerQuantity;
        }

        public ProductDetails(string Data)
        {
            string[] value=Data.Split(',');
            s_productId=int.Parse(value[0].Remove(0,3));
            ProductId=value[0];
            ProductName=value[1];
            QuantityAvailable=int.Parse(value[2]);
            PricePerQuantity=int.Parse(value[3]);
        }
        public void ShowProduct()
        {
            System.Console.WriteLine("The product id is: "+ProductId);
            System.Console.WriteLine("The product Name is: "+ProductName);
            System.Console.WriteLine("The available quantity is : "+QuantityAvailable);
            System.Console.WriteLine("The Price per quantity is: "+PricePerQuantity);
            System.Console.WriteLine("");
        }
    }
}