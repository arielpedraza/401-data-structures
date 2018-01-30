using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Node A = new Node(8);
            Node B = new Node(4);
            Node C = new Node(6);
            Node D = new Node(9);
            Node E = new Node(3);
            Node F = new Node(5);
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

            Console.WriteLine("\nA = 8, B = 4, C = 6, D = 9, E = 3, F = 5, G = 7");
            Console.WriteLine("\nE is the smallest with 3. D is the largest with 9.\n");

            Console.WriteLine("FindMin(A): " + FindMin(A));
            Console.WriteLine("FindMax(A): " + FindMax(A));

            Console.ReadLine();
        }

        private static int FindMin(Node root)
        {
            int temp1 = 0;
            int temp2 = 0;
            if (root.Left != null)
            {
                temp1 = FindMin(root.Left);
            }
            if(root.Right != null)
            {
                temp2 = FindMin(root.Right);
            }
            else
            {
                return root.Value;
            }
            return temp1 < temp2 ? temp1 : temp2;
        }

        private static int FindMax(Node root)
        {
            int temp1 = 0;
            int temp2 = 0;
            if (root.Left != null)
            {
                temp1 = FindMax(root.Left);
            }
            if (root.Right != null)
            {
                temp2 = FindMax(root.Right);
            }
            else
            {
                return root.Value;
            }
            return temp1 > temp2 ? temp1 : temp2;
        }
    }
}
