using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class NodeClass
    {
        public int Value { get; set; }
        internal NodeClass Next { get; set; }
        internal NodeClass Prev { get; set; }

        public NodeClass(int value)
        {
            Value = value;
        }
    }
}
