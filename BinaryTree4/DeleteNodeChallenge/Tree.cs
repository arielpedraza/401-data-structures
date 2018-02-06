using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteNodeChallenge
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
                if (Current.Left == null)
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
            int mid = sortedArray.Length / 2;
            Root = new Node(sortedArray[mid]);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (i == mid) continue;
                Current = Root;
                AddBSTNode(sortedArray, i);
            }
        }

        private void AddBSTNode(int[] sortedArray, int index)
        {
            if (sortedArray[index] < Current.Value)
            {
                if (Current.Left == null)
                {
                    Current.Left = new Node(sortedArray[index]);
                }
                else
                {
                    Current = Current.Left;
                    AddBSTNode(sortedArray, index);
                }
            }
            else // sortedArray[index] > Root.Value
            {
                if (Current.Right == null)
                {
                    Current.Right = new Node(sortedArray[index]);
                }
                else
                {
                    Current = Current.Right;
                    AddBSTNode(sortedArray, index);
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
