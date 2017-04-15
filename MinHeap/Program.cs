using System;

namespace MinHeap
{
    class Program
    {
        static void Main(string[] args)
        {
          MinHeap m = new MinHeap();
          m.insertKey(6);
          m.insertKey(5);
          m.insertKey(4);
          m.insertKey(3);
          m.insertKey(2);
          m.insertKey(1);
          m.insertKey(0);
          m.PrintHeap();
          Console.WriteLine();
          Console.WriteLine(m.GetMin());
          m.DecreaseKey(3, -1);
          Console.WriteLine();
          m.PrintHeap();
          Console.WriteLine();
          Console.WriteLine(m.ExtractMin());
          Console.WriteLine();
          m.PrintHeap();
          Console.WriteLine();
          Console.WriteLine(m.ExtractMin());
          m.PrintHeap();
          Console.WriteLine();
          Console.WriteLine(m.ExtractMin());
          m.PrintHeap();
          Console.WriteLine();
           Console.WriteLine();
          Console.WriteLine(m.ExtractMin());
          m.PrintHeap();
          Console.WriteLine();
 
        }
        
        
    }
}
