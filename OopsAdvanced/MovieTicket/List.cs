using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public partial class List
    {
        private int _count=0;
        private int _capacity=0;
        public Type[] Array { get; set; }
        public int Count { get{ return _count;}  }
        public int Capacity { get{return _capacity;} }

        public Type this[int i]{ get{return Array[i];} set{Array[i]=value;} }

       /* public void List()
        {
            _count=0;
            _capacity=4;
            Array[] = new Array[_capacity];
        }*/







        
    }
}