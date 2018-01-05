using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NodeClass N3 = new NodeClass(300);
            LinkedListClass LL = new LinkedListClass(N3);
            Console.WriteLine("Called new LinkedListClass(N3)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.ReadLine();

            NodeClass N5 = new NodeClass(500);
            LL.AddLast(N5);
            Console.WriteLine("Called AddLast(N5)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.ReadLine();

            NodeClass N1 = new NodeClass(100);
            LL.AddFirst(N1);
            Console.WriteLine("Called AddFirst(N1)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.WriteLine("Third Item Prev Value: " + LL.Head.Next.Next.Prev.Value);
            Console.WriteLine("Third Item Value: " + LL.Head.Next.Next.Value);
            Console.ReadLine();

            NodeClass N2 = new NodeClass(200);
            LL.AddBefore(N3, N2);
            Console.WriteLine("Called AddBefore(N3, N2)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.WriteLine("Third Item Prev Value: " + LL.Head.Next.Next.Prev.Value);
            Console.WriteLine("Third Item Value: " + LL.Head.Next.Next.Value);
            Console.WriteLine("Fourth Item Prev Value: " + LL.Head.Next.Next.Next.Prev.Value);
            Console.WriteLine("Fourth Item Value: " + LL.Head.Next.Next.Next.Value);
            Console.ReadLine();

            NodeClass N4 = new NodeClass(400);
            LL.AddAfter(N3, N4);
            Console.WriteLine("Called AddAfter(N3, N4)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.WriteLine("Third Item Prev Value: " + LL.Head.Next.Next.Prev.Value);
            Console.WriteLine("Third Item Value: " + LL.Head.Next.Next.Value);
            Console.WriteLine("Fourth Item Prev Value: " + LL.Head.Next.Next.Next.Prev.Value);
            Console.WriteLine("Fourth Item Value: " + LL.Head.Next.Next.Next.Value);
            Console.WriteLine("Fifth Item Prev Value: " + LL.Head.Next.Next.Next.Next.Prev.Value);
            Console.WriteLine("Fifth Item Value: " + LL.Head.Next.Next.Next.Next.Value);
            Console.ReadLine();

            LL.Remove(N3);
            Console.WriteLine("Called Remove(N3)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.WriteLine("Third Item Prev Value: " + LL.Head.Next.Next.Prev.Value);
            Console.WriteLine("Third Item Value: " + LL.Head.Next.Next.Value);
            Console.WriteLine("Fourth Item Prev Value: " + LL.Head.Next.Next.Next.Prev.Value);
            Console.WriteLine("Fourth Item Value: " + LL.Head.Next.Next.Next.Value);
            Console.ReadLine();

            LL.Remove(N1);
            Console.WriteLine("Called Remove(N1)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.WriteLine("Third Item Prev Value: " + LL.Head.Next.Next.Prev.Value);
            Console.WriteLine("Third Item Value: " + LL.Head.Next.Next.Value);
            Console.ReadLine();

            LL.Remove(N5);
            Console.WriteLine("Called Remove(N5)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.ReadLine();

            LL.Remove(N5);
            Console.WriteLine("Called Remove(N5) (should not do anything)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.ReadLine();

            LL.AddAfter(N3, N4);
            Console.WriteLine("Called AddAfter(N3, N4) (should not do anything)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.ReadLine();

            LL.AddBefore(N3, N4);
            Console.WriteLine("Called AddBefore(N3, N4) (should not do anything)");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.WriteLine("Second Item Prev Value: " + LL.Head.Next.Prev.Value);
            Console.WriteLine("Second Item Value: " + LL.Head.Next.Value);
            Console.ReadLine();

            LL.Remove(N2);
            LL.Remove(N4);
            Console.WriteLine("Called remove on N2 and N4. Linked List should be empty.");
            Console.ReadLine();

            LL.Remove(N1);
            Console.WriteLine("Called remove on N1. Shouldn't have done anything. Linked List should still be empty.");
            Console.ReadLine();

            LL.AddLast(N5);
            Console.WriteLine("Called AddLast(N5) on empty linked list.");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.ReadLine();

            LL.Remove(N5);
            Console.WriteLine("Called remove on N5. Linked List should be empty again.");
            Console.ReadLine();

            LL.AddFirst(N1);
            Console.WriteLine("Called AddFirst(N1) on empty linked list.");
            Console.WriteLine("Head value is: " + LL.Head.Value);
            Console.ReadLine();
        }
    }
}
