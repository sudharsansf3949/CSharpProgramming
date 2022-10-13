using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayList
{
    public partial class ArrayList
    {
        public void Insert(int index,dynamic value)
        {
            dynamic[] temp=new dynamic[_capacity+1];
            for(int i=0;i<_count+1;i++)
            {
                if(i<index)
                {
                    temp[i]=Array [i];
                }
                else if(i==index)
                {
                    temp[i]=value;
                }
                else if(i>index)
                {
                    temp[i]=Array[i-1];
                }
            }
            Array=temp;
        }

        public void RemoveAt(int index)
        {
            for(int i=0;i<_count;i++)
            {
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
            }
        }

        public void Remove(dynamic value)
        {
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(value))
                {
                    for(int j=i;j<_count-1;j++)
                    {
                        Array[j]=Array[j+1];
                    }
                }
            }
        }

        public int IndexOf(dynamic value)
        {
            for (int i=0;i<_count;i++)
            {
               if(Array[i].Equals(value))
               {
                 return i;
               }
            }
            return -1;
        }


    }
}