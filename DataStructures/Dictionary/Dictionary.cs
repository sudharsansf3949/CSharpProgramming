using System;

namespace Dictionary
{
    public class KeyValue<TKey,Tvalue>
    {
        public TKey Key{get; set;}
        public Tvalue Value { get; set; }
      
    }

    public partial class Dictionary<Tkey,Tvalue>
    {
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;}  }
        private int _count=0;
        private int _capacity=0;
        public KeyValue<Tkey,Tvalue> [] Array{get; set;}
        public Dictionary(int size)
        {
            if(size==0)
            {
                _capacity=4;
                _count=0;
                Array=new KeyValue<Tkey,Tvalue>[_capacity];
            }
            else if(size>0)
            {
                _capacity=size*2;
                Array =new KeyValue<Tkey,Tvalue>[_capacity];
            }
        }

        public void Add(Tkey key,Tvalue value)
        {
            if(_capacity==_count)
            {
                Expand();
            }
            
            bool temp=LinearSearch(key,out int index);
            if(temp==true)
            {
                System.Console.WriteLine("Duplicate Key");
            }
            if(temp==false)
            {
                KeyValue<Tkey,Tvalue> entry =new KeyValue<Tkey, Tvalue>();
                entry.Key=key;
                entry .Value=value;
                Array[_count]=entry;
                _count++;
            }
        }

        public void Expand()
        {
            _capacity=_capacity*2;
            KeyValue<Tkey,Tvalue> []temp =new KeyValue<Tkey, Tvalue>[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }

        public void Display()
        {
            foreach(KeyValue<Tkey,Tvalue> element in Array)
            {
                if(element!=null)
                {
                    System.Console.WriteLine($"Key: {element.Key} \t  Value:{element.Value}");
                }
            }
        }

        public bool LinearSearch(Tkey key, out int index)
        {
            bool temp =false;
            index=0;
            for(int i=0;i<_count;i++)
            {
                if(key.Equals(Array[i].Key))
                {
                    index=i;
                    temp=true;
                    return temp;   
                }
            }
            return temp;
           
        }

        public Tvalue this[Tkey key]    //Indexer
        {
            get
            {
                Tvalue output=default(Tvalue);
                int index=0;
                bool temp=LinearSearch(key,out index);
                if(temp)
                {
                    output=Array[index].Value;
                }
                else
                {
                    System.Console.WriteLine("Invalid key");
                }
                return output;
            }
            set
            {
                int position=0;
                bool temp=LinearSearch(key,out position);
                if(temp)
                {
                    Array[position].Value=value;
                }
                else
                {
                    System.Console.WriteLine("Invalid key");
                }
            }
        }

        
    }
}