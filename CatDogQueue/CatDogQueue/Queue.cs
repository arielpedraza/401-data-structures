using System;
using System.Collections.Generic;
using System.Text;

namespace CatDogQueue
{
    class Queue
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        internal int Length { get; set; }

        public Queue(string n)
        {
            Head = new Node(n);
            Tail = Head;
            Length = 1;
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
            Length++;
        }

        public void DequeueAny()
        {
            if (Head.Value == "cat") DequeueCat();
            else DequeueDog();
        }

        public void DequeueCat()
        {
            if (Head.Value == "cat")
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
                Node temp = Tail;
                string n = "";
                while (temp != Head)
                {
                    Console.WriteLine("Inside while loop, temp is " + temp.Value);
                    n = Head.Value;
                    Enqueue(n);
                    Head = Head.Prev;
                    Head.Next = null;
                }
            }
            Length--;
        }

        public void DequeueDog()
        {
            if (Head.Value == "dog")
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
                Node temp = Tail;
                string n = "";
                while (Tail != Head)
                {
                    Console.WriteLine("Inside while loop, temp is " + temp.Value);
                    n = Head.Value;
                    Enqueue(n);
                    Head = Head.Prev;
                    Head.Next = null;
                }
                /*string n = Head.Value;
                n = Head.Value;
                Enqueue(n);
                Head = Head.Prev;
                Head.Next = null;
                DequeueDog();*/
            }
            Length--;
        }

        public string Peek() => Head.Value;
    }
}
