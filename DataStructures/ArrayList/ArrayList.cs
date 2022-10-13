using System;

namespace ArrayList
{
    public partial class ArrayList
    {
        private int _count;
        private int _capacity;
        private dynamic[] Array { get; set; }
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;}}

        public dynamic this[int i]     //Indexers
        {
            get
            {
                return Array[i];
            }
            set
            {
                Array[i]=value;
            }
        }

        public ArrayList()
        {
            _count=0;
            _capacity=6;
            Array=new dynamic[_capacity];
        }

        public void Add(dynamic data)
        {
            if(_capacity==_count)
            {
                GrowSize();
            }
            Array[_count]=data;
            _count++;
        }

        public void GrowSize()
        {
            _capacity=_capacity*2;
            dynamic[] temp=new dynamic[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }
    }
}