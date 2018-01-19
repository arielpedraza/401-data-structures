using System;

namespace TreeAnimalGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node A = new Node("Is it a mammal?");
            Node B = new Node("Dog?");

            A.Left = B;

            do
            {
                Console.WriteLine("Starting Game:");
            } while (GameLogic(A));
        }

        public static bool GameLogic(Node node)
        {
            Console.WriteLine(node.Value);
            string input = Console.ReadLine();
            if(input == "yes")
            {
                Console.WriteLine(node.Left.Value);
                input = Console.ReadLine();
                if(input == "yes")
                {
                    return true;
                }
                else
                {
                    if (node.Left.Right == null)
                    {
                        return HelperMethod(node.Left);
                    }
                    else
                    {
                        return GameLogic(node.Left.Right);
                    }
                }
            }
            else
            {
                if (node.Right == null)
                {
                    return HelperMethod(node);
                }
                else
                {
                    return GameLogic(node.Right);
                }
            }
        }

        private static bool HelperMethod(Node node)
        {
            Console.WriteLine("Enter a new question:");
            string input = Console.ReadLine();
            node.Right = new Node(input);
            Console.WriteLine("Enter an answer to that question:");
            input = Console.ReadLine();
            node.Right.Left = new Node(input);
            return true;
        }
    }
}
