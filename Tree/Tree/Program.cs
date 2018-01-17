using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node A = new Node('A');
            Node B = new Node('B');
            Node C = new Node('C');
            Node D = new Node('D');
            Node E = new Node('E');
            Node F = new Node('F');
            Node G = new Node('G');

            A.LeftChild = B;
            A.RightChild = C;
            B.LeftChild = D;
            B.RightChild = E;
            C.LeftChild = F;
            C.RightChild = G;

            Console.WriteLine("          A          ");
            Console.WriteLine("         / \\        ");
            Console.WriteLine("        B   C        ");
            Console.WriteLine("       / \\ / \\     ");
            Console.WriteLine("      D  E F  G      ");

            Console.WriteLine("\nCalled PreOrder(A)");
            PreOrder(A);
            Console.WriteLine("\nCalled InOrder(A)");
            InOrder(A);
            Console.WriteLine("\nCalled PostOrder(A)");
            PostOrder(A);
            Console.ReadLine();
        }

        private static void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrder(node.LeftChild);
                PreOrder(node.RightChild);
            }
        }

        private static void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.LeftChild);
                Console.WriteLine(node.Value);
                InOrder(node.RightChild);
            }
        }

        private static void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.LeftChild);
                PostOrder(node.RightChild);
                Console.WriteLine(node.Value);
            }
        }
    }
}
