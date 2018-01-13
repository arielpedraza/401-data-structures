using System;
using System.Collections.Generic;
using System.Text;

namespace CatDogQueue
{
    class Queue
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public Queue(string n)
        {
            Head = new Node(n);
            Tail = Head;
        }

        public void Enqueue(string n)
        {
            Node node = new Node(n);
            if (n != "cat" && n != "dog")
            {
                Console.WriteLine("Can not enqueue something other than cat or dog.");
                return;
            }
            else if (Tail == null)
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

        public Node DequeueAny()
        {
            if (Head.Value == "cat") return DequeueCat();
            else return DequeueDog();
        }

        public Node DequeueCat()
        {
            return Dequeue("cat");
        }

        public Node DequeueDog()
        {
            return Dequeue("dog");
        }

        private Node Dequeue(string s)
        {
            Node temp = Head;
            if (Head.Value == s)
            {
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Prev;
                    Head.Next = null;
                }
            }
            else
            {
                Node tail = Tail;
                string n = "";
                bool notFound = true;
                while (tail != Head)
                {
                    if (notFound && Head.Value == s)
                    {
                        notFound = false;
                        temp = Head;
                    }
                    else
                    {
                        n = Head.Value;
                        Enqueue(n);
                    }
                    Head = Head.Prev;
                    Head.Next = null;
                }
            }
            return temp;
        }

        public string Peek() => Head.Value;
    }
}