using System;
using System.Collections.Generic;
using System.Text;

namespace PopulateTreeApp
{
    class Tree
    {
        private Node Root { get; set; }
        private Node Current { get; set; }
        Queue<Node> myQueue;

        public void CreateBT(int[] sortedArray)
        {
            myQueue = new Queue<Node>();
            int i = 0;
            Root = new Node(sortedArray[i]);
            Current = Root;
            i++;

            while (i < sortedArray.Length)
            {
                if(Current.Left == null)
                {
                    Current.Left = new Node(sortedArray[i]);
                    i++;
                }
                else if (Current.Right == null)
                {
                    Current.Right = new Node(sortedArray[i]);
                    i++;
                }
                else
                {
                    myQueue.Enqueue(Current.Left);
                    myQueue.Enqueue(Current.Right);
                    Current = myQueue.Dequeue();
                }
            }
        }

        //public void CreateBST(int[] sortedArray)
        //{
        //    myQueue = new Queue<Node>();
        //    int Mid = (int)Math.Floor((decimal)(sortedArray.Length/2));
        //    myQueue.Enqueue(new Node(sortedArray[Mid]));
        //    CreateBST();
        //    CreateBST();
        //}

        public void PrintTree()
        {
            PreOrder(Root);
        }

        private void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }
    }
}
