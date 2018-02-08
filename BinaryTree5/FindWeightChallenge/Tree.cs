using System;
using System.Collections.Generic;
using System.Text;

namespace FindWeightChallenge
{
    class Tree
    {
        private Node Root { get; set; }
        Queue<Node> myQueue;

        public void CreateBT(int[] sortedArray)
        {
            myQueue = new Queue<Node>();
            int i = 0;
            Root = new Node(sortedArray[i]);
            Node Current = Root;
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

        public void CreateBST(int[] sortedArray)
        {
            int mid = sortedArray.Length/2;
            Root = new Node(sortedArray[mid]);
            Node current;

            for(int i=0; i < sortedArray.Length; i++)
            {
                if (i == mid) continue;
                current = Root;
                AddBSTNode(sortedArray, i, current);
            }
        }

        private void AddBSTNode(int[] sortedArray, int index, Node current)
        {
            if (sortedArray[index] < current.Value)
            {
                if (current.Left == null)
                {
                    current.Left = new Node(sortedArray[index]);
                }
                else
                {
                    current = current.Left;
                    AddBSTNode(sortedArray, index, current);
                }
            }
            else // sortedArray[index] > Root.Value
            {
                if (current.Right == null)
                {
                    current.Right = new Node(sortedArray[index]);
                }
                else
                {
                    current = current.Right;
                    AddBSTNode(sortedArray, index, current);
                }
            }
        }

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
