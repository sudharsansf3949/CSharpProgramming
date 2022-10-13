using System;
namespace FoodDelivery
{
    public partial class List<Type>
    {
        private Type[] Array { get; set; }
        public Type[] Array1 {get; set;}
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;}}
        public Type this[int i]
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
        private int _count;
        private int _capacity;

        public List()
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }

        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array =new Type[_capacity];
        }

        public void Add(Type data)
        { 
            if(_count==_capacity)
            {
                GrowSize();
            }
            Array[_count]=data;
            _count++;
        }

        public void AddRange(List<Type> list)
        {
            Type [] array1=new Type[_count+list.Count];
            for(int i=0;i<Count;i++)
            {
                array1[i]=Array[i];
            }
            for(int i=0;i<_count+list.Count;i++)
            {
                array1[Count+i]=list[i];
            }
            Array=array1;
            _count+=list.Count;
        }

        public void GrowSize()
        {
            _capacity=_capacity*2;
            Array1=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
        }    
    }
}