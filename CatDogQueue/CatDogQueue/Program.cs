using System;

namespace CatDogQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTesting Cat-Dog Queue!\n");
            Console.WriteLine("Creating new queue with one node value of cat");
            Queue myQueue = new Queue("cat");

            Console.WriteLine("Enqueuing node of value dog into queue");
            myQueue.Enqueue("dog");
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());

            Console.WriteLine("Calling DequeueAny()");
            myQueue.DequeueAny();
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());

            Console.WriteLine("Enqueuing node of value dog into queue");
            myQueue.Enqueue("dog");
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());

            Console.WriteLine("Enqueuing node of value cat into queue");
            myQueue.Enqueue("cat");
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());

            Console.WriteLine("Enqueuing node of value dog into queue");
            myQueue.Enqueue("dog");
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());

            Console.WriteLine("Enqueuing node of value dog into queue");
            myQueue.Enqueue("dog");
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());

            Console.WriteLine("DequeueCat()");
            myQueue.DequeueCat();
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());

            Console.ReadLine();
        }
    }
}
