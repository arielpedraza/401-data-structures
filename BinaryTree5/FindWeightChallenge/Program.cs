using System;

namespace FindWeightChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Using an ordered array using numbers 1-7");

            Console.WriteLine("\nCreating Binary Search Tree:");
            Tree myTree = new Tree();
            myTree.CreateBST(intArray);
            myTree.PrintTree();

            Console.WriteLine("Does weight 7 exist?: " + myTree.FindWeight(7));
            Console.WriteLine("Does weight 10 exist?: " + myTree.FindWeight(10));
            Console.WriteLine("Does weight 22 exist?: " + myTree.FindWeight(22));

            Console.ReadLine();
        }
    }
}
