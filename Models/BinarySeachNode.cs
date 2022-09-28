using System;

namespace DataStructuresAlgorithms.Models
{
    public class BinarySeachNode<T>
    {
        public T Data;

        public BinarySeachNode<T>? Left {get;set;}

        public BinarySeachNode<T>? Right {get;set;}
        public BinarySeachNode(T value){
            Data = value;
        }

        public override string ToString(){
            var txt = toString(this);
            return txt;
        }

        private string toString(BinarySeachNode<T> node)
        {

            var dataString = string.Empty;
            
            var leftString = string.Empty;
            var rightString = string.Empty;

            if(node.Data != null){
                dataString = $"\t data : \"{node.Data}\"";
            }

            if(node.Left != null){
                leftString = $"\t left : {toString(node.Left)}";
            }

            if(node.Right !=null){
                rightString = $"\t right : {toString(node.Right)}";
            }

            return $"{{ \n {dataString}, \n {leftString}, \n {rightString}  }}";
        }

    }
}
