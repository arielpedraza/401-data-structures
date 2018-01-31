using System;
using System.Collections.Generic;
using System.Text;

namespace SwapLeavesApp
{
    public class Tree
    {
        public Node Root { get; }

        public Tree(Node root)
        {
            Root = root;
        }

        Stack<Node> myStack = new Stack<Node>();
        
        private Node Parent1 = null;
        private Node Parent2 = null;
        private int A = 0;
        private int B = 0;

        private void TraverseHelper(Node node)
        {
            if (node.Left != null)
            {
                myStack.Push(node);
                TraverseHelper(node.Left);
            }

            if (node.Right != null)
            {
                myStack.Push(node);
                TraverseHelper(node.Right);
            }
            else // is leaf node
            {
                if (node.Value == A)
                {
                    Parent1 = myStack.Pop();
                }
                else if (node.Value == B)
                {
                    Parent2 = myStack.Pop();
                }
                else
                {
                    myStack.Pop();
                }
            }
        }

        public void SwapNodes(int a, int b)
        {
            Node Current = Root;
            A = a;
            B = b;

            TraverseHelper(Current);

            Node Temp = null;

            if(Parent2.Left.Value == B)
            {
                if (Parent1.Left.Value == A)
                {
                    Temp = Parent1.Left;
                    Parent1.Left = Parent2.Left;
                    Parent2.Left = Temp;
                }
                else // Parent1.Right.Value == A
                {
                    Temp = Parent1.Right;
                    Parent1.Right = Parent2.Left;
                    Parent2.Left = Temp;
                }
            }
            else // Parent2.Right.Value == B
            {
                if (Parent1.Left.Value == A)
                {
                    Temp = Parent1.Left;
                    Parent1.Left = Parent2.Right;
                    Parent2.Left = Temp;
                }
                else // Parent1.Right.Value == A
                {
                    Temp = Parent1.Right;
                    Parent1.Right = Parent2.Right;
                    Parent2.Left = Temp;
                }
            }
        }
    }
}
