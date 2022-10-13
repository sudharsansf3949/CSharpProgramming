using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterDeligates
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }    
    }
    public delegate bool FilterDelegate(Person P);    //Our Deligate
}