using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NodeClass N1 = new NodeClass(100);
            LinkedListClass LL = new LinkedListClass(N1);
            Console.WriteLine("Called new LinkedListClass(N1)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Node N1 value is: " + N1.Value);
            Console.ReadLine();

            NodeClass N2 = new NodeClass(200);
            LL.AddLast(N2);
            Console.WriteLine("Called AddLast(N2)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Node N1 next is: " + N1.Next.Value);
            Console.WriteLine("Node N2 value is: " + N2.Value);
            Console.ReadLine();

            NodeClass N3 = new NodeClass(300);
            LL.AddFirst(N3);
            Console.WriteLine("Called AddFirst(N3)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Head next is: " + LL.Head.Next.Value);
            Console.WriteLine("Node N1 value is: " + N1.Value);
            Console.WriteLine("Node N1 next is: " + N1.Next.Value);
            Console.WriteLine("Node N2 value is: " + N2.Value);
            Console.ReadLine();
            
            NodeClass N4 = new NodeClass(400);
            LL.AddBefore(N1, N4);
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.WriteLine("Third Item Value: " + LL.Head.Next.Next.Value);
            Console.WriteLine("Fourth Item Value: " + LL.Head.Next.Next.Next.Value);
            Console.ReadLine();
            
        }
    }
}
