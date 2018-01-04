using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
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
            Current.Next = newNode;
            ListSize++;
        }

        public void AddAfter(NodeClass targetNode, NodeClass newNode)
        {
            NodeClass Current = Head;
            while(Current != targetNode)
            {
                Current = Current.Next;
            }
            newNode.Next = targetNode.Next;
            targetNode.Next = newNode;
            ListSize++;
        }

        public void Remove(NodeClass targetNode)
        {
            NodeClass Current = Head;
            while(Current.Next != targetNode)
            {
                Current = Current.Next;
            }
            Current.Next = Current.Next.Next;
            targetNode.Next = null;
            ListSize--;
        }

        public NodeClass GetMiddle()
        {
            if (Head == null) return null;
            int tempCount = 0;
            if (ListSize % 2 == 1) tempCount = (ListSize + 1) / 2;
            else tempCount = ListSize / 2;

            NodeClass Current = Head;
            for(int i = 1; i < tempCount; i++)
            {
                Current = Current.Next;
            }
            return Current;
        }

        public NodeClass GetMiddleRunner()
        {
            if (Head == null) return null;
            NodeClass walker = Head;
            NodeClass runner = Head;

            while(runner.Next.Next != null)
            {
                walker = walker.Next;
                runner = runner.Next.Next;
            }
            return walker;
        }

        public NodeClass GetNodeFromEnd(int nth)
        {
            if (nth > ListSize) return null;
            NodeClass Current = Head;
            int diff = ListSize - nth;
            while(diff > 0)
            {
                Current = Current.Next;
                diff--;
            }
            return Current;
        }
    }
}
