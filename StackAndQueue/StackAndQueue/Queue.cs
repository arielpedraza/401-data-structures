using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Queue
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public Queue(int n)
        {
            Head = new Node(n);
            Tail = Head;
        }

        public void Enqueue(int n)
        {
            Node node = new Node(n);
            if(Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Tail;
                Tail.Prev = node;
                Tail = node;
            }
        }

        public void Dequeue()
        {
            if(Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head?.Prev;
            }
        }

        public int Peek() => Head.Value;
    }
}
