using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Node
    {
        public int Value { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public Node(int num)
        {
            Value = num;
        }
    }
}
