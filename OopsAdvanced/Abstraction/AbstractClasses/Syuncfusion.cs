using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Syuncfusion:AbstractBase
    {
        //abstract property definition
        public override string Name{ get{return name;} set{name=value;}}
            //Abstract method definition
        public override void Salary(int dates)
        {
            Display();
            Amount=(double)dates*500;
            System.Console.WriteLine(Amount);
        }


    }
}