using System;

namespace SwapLeavesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node A = new Node(1);
            Node B = new Node(2);
            Node C = new Node(3);
            Node D = new Node(4);
            Node E = new Node(5);
            Node F = new Node(6);
            Node G = new Node(7);

            A.Left = B;
            A.Right = C;
            B.Left = D;
            B.Right = E;
            C.Left = F;
            C.Right = G;

            Console.WriteLine("          A          ");
            Console.WriteLine("         / \\        ");
            Console.WriteLine("        B   C        ");
            Console.WriteLine("       / \\ / \\     ");
            Console.WriteLine("      D  E F  G      ");

            Tree myTree = new Tree(A);

            Console.WriteLine("\nCalled PostOrder(A)");
            PostOrder(A);

            Console.WriteLine("\nSwapping E & F (5 & 6)");
            myTree.SwapNodes(5, 6);

            Console.WriteLine("\nCalled PostOrder(A)");
            PostOrder(A);

            Console.ReadLine();
        }

        private static void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.WriteLine(node.Value);
            }
        }
    }
}
