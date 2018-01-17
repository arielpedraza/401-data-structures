using System;
using System.Collections.Generic;
using System.Text;

namespace Tree2
{
    class Node
    {
        public char Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(char value)
        {
            Value = value;
        }
    }
}
