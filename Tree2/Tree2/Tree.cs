using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tree2
{
    class Tree
    {
        Queue<Node> myQueue = new Queue<Node>();

        public void BreadthFirst(Node n)
        {
            Console.WriteLine(n.Value);
            if (n.Left != null) myQueue.Enqueue(n.Left);
            if (n.Right != null) myQueue.Enqueue(n.Right);
            if(myQueue.Count > 0)
            {
                BreadthFirst(myQueue.Dequeue());
            }
        }
    }
}
