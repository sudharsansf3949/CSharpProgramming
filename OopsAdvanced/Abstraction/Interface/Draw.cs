using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:IRectangle
    {
        public double Area { get; set; }
        public double Length { get; set; }
        public  double Breath { get; set; }

        public Draw(double length,double breath)
        {
            Length=length;
            Breath=breath;
        }
            
        public void CalculateArea()
        {
            double Area=Length*Breath;
        }
        public void Show()
        {
            System.Console.WriteLine("The Area is: "+Area);
        }
        

    }
}