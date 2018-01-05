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
            newNode.Next = Head;
            Head = newNode;
            Head.Next.Prev = Head;
            ListSize++;
        }

        public void AddLast(NodeClass newNode)
        {
            NodeClass Current = Head;
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
            Current.Next.Prev = Current;
            ListSize++;
        }

        public void AddBefore(NodeClass targetNode, NodeClass newNode)
        {
            NodeClass Current = Head;
            while(Current.Next != targetNode)
            {
                Current = Current.Next;
            }
            newNode.Next = Current.Next;
            Current.Next.Prev = newNode;
            Current.Next = newNode;
            newNode.Prev = Current;
            ListSize++;
        }

        public void AddAfter(NodeClass targetNode, NodeClass newNode)
        {
            NodeClass Current = Head;
            while(Current != targetNode)
            {
                Current = Current.Next;
            }
            newNode.Next = Current.Next;
            Current.Next.Prev = newNode;
            Current.Next = newNode;
            newNode.Prev = Current;
            ListSize++;
        }

        public void Remove(NodeClass targetNode)
        {
            NodeClass Current = Head;
            while(Current != targetNode)
            {
                Current = Current.Next;
            }
            Current.Prev.Next = Current.Next;
            Current.Next.Prev = Current.Prev;
            Current = null;
            ListSize--;
        }
    }
}
