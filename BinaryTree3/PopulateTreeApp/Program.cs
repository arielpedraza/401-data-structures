using System;

namespace PopulateTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intArray = new int[] {1,2,3,4,5,6,7};
            Console.WriteLine("Using an ordered array using numbers 1-7");

            Console.WriteLine("\nCreating Binary Tree:");
            Tree myTree1 = new Tree();
            myTree1.CreateBT(intArray);
            myTree1.PrintTree();

            //Console.WriteLine("\nCreating Binary Search Tree:");
            //Tree myTree2 = new Tree();
            //myTree2.CreateBST(intArray);
            //myTree2.PrintTree();

            Console.ReadLine();
        }
    }
}
