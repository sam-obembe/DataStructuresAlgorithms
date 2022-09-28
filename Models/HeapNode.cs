using System;

namespace DataStructuresAlgorithms.Models
{
    public class HeapNode<T>
    {
        public T Data;

        public HeapNode<T> LeftChild;

        public HeapNode<T> RightChild;
        public HeapNode(T data){
            Data = data;
        }

    }
}
