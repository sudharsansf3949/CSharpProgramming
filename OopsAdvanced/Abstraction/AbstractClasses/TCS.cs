using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class TCS:AbstractBase
    {
         public override string Name{ get{return name;} set{name=value;}}
            //Abstract method definition
        public override void Salary(int dates)
        {
            Display();    //calling Abstract class normal method
            Amount=(double)dates*300;
            System.Console.WriteLine(Amount);
        }
    }
}