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

            //number of levels in heap is equal to Log2N
            var levels = (int)Math.Ceiling(Math.Log2(Data.Count));

            //each level is a List of ints
            var splitIntoLevels = new List<int>[levels];
            var arrPosition = 0;
            var levelPosition = 0;

            while (levelPosition < levels)
            {
                var entries = new List<int>();
                var maxCount = ((int)Math.Pow(2,levelPosition)); //the maximum number of elements for that level
                var takenData = Data.Take(new Range(arrPosition, arrPosition + maxCount)).ToList().Select(x => x.Data);
                entries.AddRange(takenData);
                

                splitIntoLevels[levelPosition] = new List<int>(entries);
                arrPosition += maxCount;
                levelPosition++;
                
            }

            for(int i = 0 ; i < splitIntoLevels.Count(); i++){
                //var 
                var numOfTabs = (int)Math.Ceiling((splitIntoLevels.Count() - i)/2m);
                var tabs = new char[numOfTabs];
                for(int j = 0 ; j < numOfTabs; j++){
                    tabs[j] = '\t';
                }
                var tabString = new string(tabs);
                var output = tabString + string.Join('\t',splitIntoLevels[i]);
                Console.WriteLine(output);
            }
        }

        private int NumberOfTabs(List<int>[] heap, int level){
            var numOfElementsAtLevel = (int)Math.Pow(2,level);
            var numOfParents = (int)Math.Pow(2,level-1);
            var parentLevel = level - 1;

            return numOfElementsAtLevel + numOfParents + parentLevel;
        }

    }
}
