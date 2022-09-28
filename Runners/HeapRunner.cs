using System;
using DataStructuresAlgorithms.Models;

namespace DataStructuresAlgorithms.Runners
{
    public class HeapRunner
    {

        /// <summary>
        /// Accepts an interger and creates a heap with the integer as the root node and a list of values to insert into the heap
        /// </summary>
        /// <param name="startingValue"></param>
        /// <param name="insertionValue"></param>
        public static void Run(int startingValue, int[]? insertionValues)
        {
            var root = new HeapNode<int>(startingValue);
            var heap = new Heap(root);

            Console.WriteLine(heap.GetRootNode());

            if (insertionValues != null)
            {
                foreach (int val in insertionValues)
                {
                    heap.Insert(val);
                    //heap.Display();
                }
                heap.Display();
            }

        }


    }
}
