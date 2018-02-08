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

            

            Console.ReadLine();
        }
    }
}
