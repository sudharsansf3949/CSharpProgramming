using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Operations
    {
        static public int Partition(int[] array,int left,int right)
        {
            int pivot;
            pivot=array[left];
            while(true)
            {
                while(array[left]<pivot)
                {
                    left++;
                }
                while(array[right]>pivot)
                {
                    right--;
                }
                if(left<right)
                {
                    int temp=array[right];
                    array[right]=array[left];
                    array[left]=temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void Sort(int[] array,int left,int right)
        {
            int pivot;
            if(left<right)
            {
                pivot=Partition(array,left,right);
                if(pivot>1)
                {
                    Sort(array,left,pivot-1);
                }
                if(pivot+1<right)
                {
                    Sort(array,pivot+1,right);
                }
            }
        }
    }
}