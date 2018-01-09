using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Stack
    {
        public Node Head { get; private set; }

        public Stack(int n)
        {
            Head = new Node(n);
        }

        public void Enqueue(int n)
        {
            Node node = new Node(n);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public void Dequeue() => Head = Head?.Next;

        public int Peek() => Head.Value;
    }
}
