using System;
using System.Collections.Generic;
using System.Text;

namespace QueueAsStacks
{
    class QueueStack
    {
        public Node S1Head { get; private set; } = null;
        public Node S2Head { get; private set; } = null;
        // Stack<Node> S1 = new Stack<Node>();
        // Stack<Node> S2 = new Stack<Node>();

        public void Enqueue(int n)
        {
            if (S1Head == null)
            {
                while(S2Head != null)
                {
                    // S1.Push(S2.Pop());
                    Node node = S2Head;
                    S2Head = S2Head.Next;
                    node.Next = S1Head;
                    S1Head = node;
                }
            }
            // S1.Push(S1Head);
            Node temp = new Node(n){ Next = S1Head };
            S1Head = temp;
        }

        public Node Dequeue()
        {
            if (S2Head == null)
            {
                while (S1Head != null)
                {
                    // S2.Push(S1.Pop());
                    Node node = S1Head;
                    S1Head = S1Head.Next;
                    node.Next = S2Head;
                    S2Head = node;
                }
            }
            Node temp = S2Head;
            S2Head = S2Head.Next;
            return temp;
        }

        public int Peek()
        {
            if (S2Head == null)
            {
                while (S1Head != null)
                {
                    // S2.Push(S1.Pop());
                    Node node = S1Head;
                    S1Head = S1Head.Next;
                    node.Next = S2Head;
                    S2Head = node;
                }
            }
            return S2Head.Value;
        }
    }
}
