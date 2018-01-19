using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAnimalGuess
{
    class Node
    {
        public string Value { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public Node(string s)
        {
            Value = s;
        }
}
}
