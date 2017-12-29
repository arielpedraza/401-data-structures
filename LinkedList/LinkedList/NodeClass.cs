using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class NodeClass
    {
        public int Value { get; set; }
        internal NodeClass Next { get; set; }

        public NodeClass(int value)
        {
            Value = value;
        }
    }
}
