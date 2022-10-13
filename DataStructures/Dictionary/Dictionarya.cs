using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionary
{
    public partial class Dictionary<Tkey,Tvalue>
    {
        public bool ContainsKey(Tkey key)
        {
            bool temp=LinearSearch(key,out int index);
            if(temp==true)
            {
                temp=true;
            }
            else
            {
                temp=false;
            }
            return temp;
        }

        public bool ContainsValue(Tvalue value)
        {
            bool temp =false;
            for(int i=0;i<_count;i++)
            {
                if(value.Equals(Array[i].Key))
                {
                    temp=true;
                    return temp;   
                }
            }
            return temp;
        }

        public KeyValue<Tkey,Tvalue> ElementAt(int index)
        {
            KeyValue<Tkey,Tvalue> output=null;
            if(index>-1 && index<Count)
            {
                output=Array[index];
            }
            else
            {
                System.Console.WriteLine("Tried to access out of bond");
            }
            return output;
        }
        public bool Remove(Tkey key)
        {
            int index=0;
            bool temp=LinearSearch(key,out index);
            if(temp==true)
            {
                for(int i=index;i<Count-1;i++)
                {
                    Array[index]=Array[index+1];
                }
                temp=true;
            }
            else
            {
                temp=false;
            }  
            return temp;
        }
    }
}