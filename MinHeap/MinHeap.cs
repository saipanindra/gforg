using System;
using System.Collections.Generic;

namespace MinHeap
{
    class MinHeap
    {
       private List<int> heapContents;

       public MinHeap()
       {
           heapContents = new List<int>();
       }
       
       public int parent(int i)
       {
           return (i - 1) / 2;
       }
       
       public int left(int i)
       {
           return (2 * i) + 1;
       }
       
       public int right(int i)
       {
           return (2 * i) + 2;
       }
       public void insertKey(int key)
       {
           if(heapContents.Count == 0)
           {
               heapContents.Add(key);
               return;
           }
           
           heapContents.Add(key);
           int i = heapContents.Count - 1;
           while( i > 0 && heapContents[parent(i)] > heapContents[i])
           {
               swap(i, parent(i));
               i = parent(i);
           }

       }
       public void swap(int a , int b)
       {
           int temp = heapContents[a];
           heapContents[a] = heapContents[b];
           heapContents[b] = temp;
       }
       
       public int ExtractMin()
       {
           int min = heapContents[0];
           heapContents[0] = heapContents[heapContents.Count - 1];
           heapContents.RemoveAt(heapContents.Count -1);
           MinHeapify(0);
           return min;
       }
       
       public void DecreaseKey(int i, int valueToDecreseTo)
       {
           heapContents[i] = valueToDecreseTo;
           while(i != 0 && heapContents[parent(i)] > heapContents[i])
           {
               swap(i, parent(i));
               i = parent(i);
           }
       }
       public void MinHeapify(int i)
       {
         int min_index = i;
         int left_index = left(i);
         int right_index = right(i);
         if(left_index <= heapContents.Count - 1 && heapContents[left_index] < heapContents[min_index])
         {
           min_index =  left_index;
         }
         if(right_index <= heapContents.Count - 1 && heapContents[right_index] < heapContents[min_index])
         {
           min_index = right(i);
         }
         if(min_index == i)
         {
            return;
         }
         swap(min_index, i);
         MinHeapify(min_index);
       }
         
       public int GetMin()
       {
           if(heapContents.Count == 0)
           {
               throw new Exception("No elements in heap");
           }
           return heapContents[0];
       }
       
       public void PrintHeap()
       {
           foreach(int i in heapContents)
           {
               Console.Write(i + " ");
           }
       }
       }
    }
    
    
