using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Node
    {
        public char Value { get; set; }
        public Node RightChild { get; set; }
        public Node LeftChild { get; set; }

        public Node(char c)
        {
            Value = c;
        }
    }
}
