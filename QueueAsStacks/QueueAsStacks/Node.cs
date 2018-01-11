using System;
using System.Collections.Generic;
using System.Text;

namespace QueueAsStacks
{
    public class Node
    {
        public int Value { get; set; }
        internal Node Next { get; set; }
        internal Node Prev { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
