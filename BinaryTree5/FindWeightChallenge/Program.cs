using System;

namespace FindWeightChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Using an ordered array with numbers 1-10");

            Console.WriteLine("\nCreating Binary Tree:");
            Tree myTree = new Tree();
            myTree.CreateBT(intArray);
            Console.WriteLine("\nPrinting Binary Tree using Pre-order:");
            myTree.PrintTree();

            Console.WriteLine("Does weight 15 exist?: " + myTree.FindWeight(15));
            Console.WriteLine("Does weight 16 exist?: " + myTree.FindWeight(16));
            Console.WriteLine("Does weight 18 exist?: " + myTree.FindWeight(18));
            Console.WriteLine("Does weight 10 exist?: " + myTree.FindWeight(10));
            Console.WriteLine("Does weight 11 exist?: " + myTree.FindWeight(11));
            Console.WriteLine("Does weight 100 exist?: " + myTree.FindWeight(100));

            Console.ReadLine();
        }
    }
}
