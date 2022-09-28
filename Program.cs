// See https://aka.ms/new-console-template for more information
using DataStructuresAlgorithms.Runners;
using DataStructuresAlgorithms.Models;

namespace DataStructuresAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            HeapNodeRun();
        }


        private static void BinaryTreeStuff()
        {
            BinaryTreeRunner.TestToString();
        }


        private static void HeapNodeRun()
        {
            HeapRunner.Run(1, new int[] { 100, 88, 25, 87, 16, 8, 12, 86, 50, 2, 15, 3 });
        }
    }
}