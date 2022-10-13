using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IMarkDetails
    {

        //No field
         int Physics { get; set; }    //property declaration olny allowed
         int Chemistry { get; set; }
         int Maths { get; set; }
          int Total { get; set; }
          double Average { get; set; }

          //no constuctor and objects

        void GetMark(int physics,int maths,int chemistry);
        void ShowMark();
        void Calculate();    //Method declration only allowed
          
    }
}