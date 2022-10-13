using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomerceApplication
{
    public class ProductDetails
    {
        private static int s_productId=101;
        public String ProductId { get; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ShippingDuration { get; set; }


        public  ProductDetails(string productname,double productPrice,int productStock,int shippingDuration)
        {
            s_productId++;
            ProductId="SF"+s_productId;
            ProductName=productname;
            ProductPrice=productPrice;
            ProductStock=productStock;
            ShippingDuration=shippingDuration;
            

        }
    }
}