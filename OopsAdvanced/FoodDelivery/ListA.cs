using System;

namespace FoodDelivery
{
    public partial class List<Type>
    {
        public void Insert(int index,Type value)
        {
            Type[] temp=new Type[_capacity+1];
            for(int i=0;i<_count+1;i++)
            {
                if(i<index)
                {
                    temp[i]=Array[i];
                }
                else if(i==index)
                {
                    temp[i]=value;
                    
                }
                else if(i>index)
                {
                    temp[i]=Array[i-1];
                }
                System.Console.WriteLine(temp[i]);
            }
          

        }

        public void RemoveAt(int index)
        {
            for(int i=0;i<_count-1;i++)
            { 
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
                System.Console.WriteLine(Array[i]);
            }
        }

        public void Remove(int value)
        {
            for(int i=0;i<_count-1;i++)
            {
                if(Array[i].Equals(value))
                {
                    for(int j=i;j<_count-1;j++)
                    {
                       Array[j]=Array[j+1];
                    }
                }
                System.Console.WriteLine(Array[i]);
            }
            
        }

    }
}