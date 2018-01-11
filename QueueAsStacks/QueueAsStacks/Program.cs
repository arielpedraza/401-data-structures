using System;

namespace QueueAsStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            QueueStack fakeQueue = new QueueStack();
            Console.WriteLine("Enqueue value 5");
            fakeQueue.Enqueue(5);
            Console.WriteLine("Peek: " + fakeQueue.Peek());
            Console.WriteLine("Enqueue value 10");
            fakeQueue.Enqueue(10);
            Console.WriteLine("Peek: " + fakeQueue.Peek());
            Console.WriteLine("Dequeue: " + fakeQueue.Dequeue().Value);
            Console.WriteLine("Peek: " + fakeQueue.Peek());

            Console.ReadLine();
        }
    }
}
