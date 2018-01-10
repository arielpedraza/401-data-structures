using System;
using System.Collections.Generic;
using System.Text;

namespace CatDogQueue
{
    class Node
    {
        public string Value { get; set; }
        internal Node Next { get; set; }
        internal Node Prev { get; set; }

        public Node(string value)
        {
            Value = value;
        }
    }
}
