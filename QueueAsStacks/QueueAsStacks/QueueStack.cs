using System;
using System.Collections.Generic;
using System.Text;

namespace QueueAsStacks
{
    class QueueStack
    {
        public Node S1Head { get; private set; }
        public Node S2Head { get; private set; }
        Stack<Node> S1 = new Stack<Node>();
        Stack<Node> S2 = new Stack<Node>();

        public void Enqueue(int n)
        {
            Node node = new Node(n);
            if (S1Head == null)
            {
                while(S2Head != null)
                {
                    S1.Push(S2.Pop());
                }
            }
            S1Head = new Node(n);
            S1.Push(S1Head);
        }

        public Node Dequeue()
        {
            if (S2Head == null)
            {
                while (S1Head != null)
                {
                    S2.Push(S1.Pop());
                }
            }
            return S2.Pop();
        }

        public int Peek()
        {
            if (S2Head == null)
            {
                while (S1Head != null)
                {
                    S2.Push(S1.Pop());
                }
            }
            return S2Head.Value;
        }
    }
}
