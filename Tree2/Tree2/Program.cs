using System;

namespace Tree2
{
    class Program
    {
        static void Main(string[] args)
        {
            Node A = new Node('A');
            Node B = new Node('B');
            Node C = new Node('C');
            Node D = new Node('D');
            Node E = new Node('E');
            Node F = new Node('F');
            Node G = new Node('G');

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

            Tree breadthFirstTree = new Tree();
            breadthFirstTree.BreadthFirst(A);
            Console.ReadLine();
        }
    }
}
