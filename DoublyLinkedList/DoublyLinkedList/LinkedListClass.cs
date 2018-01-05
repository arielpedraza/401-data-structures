using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class LinkedListClass
    {
        public NodeClass Head { get; private set; }
        private int ListSize { get; set; }

        public LinkedListClass(NodeClass node)
        {
            Head = node;
            ListSize = 1;
        }

        public void AddFirst(NodeClass newNode)
        {
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                Head.Next.Prev = Head;
            }
            ListSize++;
        }

        public void AddLast(NodeClass newNode)
        {
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                NodeClass Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = newNode;
                Current.Next.Prev = Current;
            }
            ListSize++;
        }

        public void AddBefore(NodeClass targetNode, NodeClass newNode)
        {
            if (Head == null) return;
            NodeClass Current = Head;
            while(Current.Next != targetNode)
            {
                if(Current.Next != null)
                {
                    Current = Current.Next;
                }
                else { return; }
            }

            newNode.Next = Current.Next;
            Current.Next.Prev = newNode;
            Current.Next = newNode;
            newNode.Prev = Current;
            ListSize++;
        }

        public void AddAfter(NodeClass targetNode, NodeClass newNode)
        {
            if (Head == null) return;
            NodeClass Current = Head;
            while(Current != targetNode)
            {
                if(Current.Next != null)
                {
                    Current = Current.Next;
                }
                else { return; }
            }
            newNode.Next = Current.Next;
            Current.Next.Prev = newNode;
            Current.Next = newNode;
            newNode.Prev = Current;
            ListSize++;
        }

        public void Remove(NodeClass targetNode)
        {
            if (Head == null) return;
            NodeClass Current = Head;
            while(Current != targetNode)
            {
                if (Current.Next != null)
                {
                    Current = Current.Next;
                }
                else { return; }
            }

            if (ListSize == 1) Head = null;
            else if (Current.Prev == null)
            {
                Head = Current.Next;
                Current.Next.Prev = null;
            }
            else if (Current.Next == null)
            {
                Current.Prev.Next = null;
            }
            else
            {
                Current.Prev.Next = Current.Next;
                Current.Next.Prev = Current.Prev;
            }
            Current = null;
            ListSize--;
        }
    }
}
