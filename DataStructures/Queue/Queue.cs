using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Queue
{
    public partial class Queue<Type>
    {
        private Type[]  Array {get; set;}
        private int _count;
        private int _capacity;
        private int _head;
        private int _tail;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;}  }
        public int Head { get{return _head;} }
        public int Tail { get{return _tail;}}

        public Queue()
        {
            _count=0;
            _capacity=4;
            _head=0;
            _tail=0;
            Array =new Type[_capacity];
        }

        public Queue(int size)
        {
            _count=0;
            _capacity=size;
            _head=0;
            _tail=0;
            Array =new Type[_capacity];
        }

        public void Enqueue(Type data)
        {
            if(_tail==_capacity)
            {
                Growsize();
            }
            Array[_tail]=data;
            _count++;
            _tail++;
        }

        public void Growsize()
        {
            _capacity=_capacity*2;
            Type[] temp =new Type[_capacity];
            for(int i=0;i<_tail;i++)
            {
                temp[i]=Array[i];
            }
            Array =temp;
        }

        public Type Dequeue()
        {
            Type value=default(Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Empty Queue");
            }
            else
            {
                value=Array[_head];
                _head++;
                _count--;
            }
            return value;
        }

        public Type Peak()
        {
            Type value=default(Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Empty Queue");
            }
            else
            {
                value=Array[_head];
            }
            return value;
        }

        public bool Contains(Type data)
        {
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(data))
                {
                    return true;
                }
            }
            return false;
        }

        

    }
}