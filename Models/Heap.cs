using System;

namespace DataStructuresAlgorithms.Models
{
    public class Heap
    {
        public HeapNode<int> Root;

        public List<HeapNode<int>> Data;
        public Heap(HeapNode<int> root)
        {
            Data = new List<HeapNode<int>>();
            Data.Add(root);
            //Data[0] = root;
        }

        public Heap() { }

        public HeapNode<int> GetRootNode()
        {
            return Data[0];
        }

        public HeapNode<int> GetLastNode()
        {
            return Data.Last();
        }

        public int LeftChildIndex(int index)
        {
            return (index * 2) + 1;
        }

        public int RightChildIndex(int index)
        {
            return (index * 2) + 2;
        }

        public int ParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        public void Insert(int data)
        {
            var node = new HeapNode<int>(data);
            Data.Add(node);

            var insertedPosition = Data.Count - 1;

            //Console.WriteLine("Trickling up");

            while (insertedPosition > 0 && Data[insertedPosition].Data > Data[ParentIndex(insertedPosition)].Data)
            {
                var parentIndex = ParentIndex(insertedPosition);
                var parentData = Data[parentIndex].Data;

                Data[parentIndex].Data = Data[insertedPosition].Data;
                Data[insertedPosition].Data = parentData;

                insertedPosition = parentIndex;
            }
        }
        public void Display()
        {

            //var dataArray = Data.ToArray();

            var levels = (int)Math.Ceiling(Math.Log2(Data.Count));
            var splitIntoLevels = new List<HeapNode<int>>[levels];
            var arrPosition = 0;

            while (arrPosition < Data.Count)
            {
                var entries = new List<HeapNode<int>>();
                for (int i = 0; i < levels; i++)
                {

                    var maxCount = i;
                    var takenData = Data.Take(new Range(arrPosition, arrPosition + maxCount)).ToList();
                    entries.AddRange(takenData);
                    splitIntoLevels[i] = entries;
                    //entries.Clear();
                    arrPosition++;
                }
                entries.Clear();
            }


            Console.WriteLine(string.Join(',', Data.Select(x => x.Data)));
        }

    }
}
