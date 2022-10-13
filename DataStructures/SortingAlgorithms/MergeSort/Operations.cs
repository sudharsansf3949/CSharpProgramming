using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MergeSort
{
    public class Operations
    {
        static public void MainMerge(int[] array,int left,int mid,int right)
        {
            int[] temp=new int[20];
            int i,flag,num,pos;
            flag=mid-1;
            pos=left;
            num=(right-left+1);

            while((left<=flag)&&(mid<=right))
            {
                if(array[left]<=array[mid])
                {
                    temp[pos++]=array[left++];
                }
                else
                {
                    temp[pos++]=array[mid++];
                }
            }
            while(left<=flag)
            {
                temp[pos++]=array[left++];
            }
            while(mid<=right)
            {
                temp[pos++]=array[mid++];
            }
            for(i=0;i<num;i++)
            {
                array[right]=temp[right];
                right--;
            }
        }
        static public void SortMerge(int[] array,int left,int right)
        {
            int mid;
            if(right>left)
            {
                mid=(right+left)/2;
                SortMerge(array,left,mid);
                SortMerge(array,(mid+1),right);
                MainMerge(array,left,(mid+1),right);
            }
        }
    }
}