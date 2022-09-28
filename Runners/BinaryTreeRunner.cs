using System;
using DataStructuresAlgorithms.Models;

namespace DataStructuresAlgorithms.Runners
{
    public class BinaryTreeRunner
    {
        public static void TestToString(){
            var root = BuildNode("root");
            var left = BuildNode("left");
            var right = BuildNode("right");

            root.Left = left;
            root.Right = right;

            var treeString = root.ToString();

            Console.WriteLine(treeString);
        }

        private static BinarySeachNode<string> BuildNode(string nodeData){
            return new BinarySeachNode<string>(nodeData);
        }


        public static BinarySeachNode<int>? Search(int value, BinarySeachNode<int>? root){
            if(root == null || root.Data.Equals(value)){
                return root;
            }

            else if(value < root.Data){
                return Search(value, root.Left);
            }

            else{
                return Search(value, root.Right);
            }
        }

        public static void Insert(int value, BinarySeachNode<int>? node){
            if(value < node.Data){
                if(node.Left is null){
                    node.Left = new BinarySeachNode<int>(value);
                }
                else{
                    Insert(value,node.Left);
                }
            }
            else if(value > node.Data){
                if(node.Right is null){
                    node.Right = new BinarySeachNode<int>(value);
                }
                else{
                    Insert(value, node.Right);
                }
            }
        }


    }
}
