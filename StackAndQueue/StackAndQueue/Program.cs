using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Stacks!\n");
            Console.WriteLine("Creating new stack with one node value of 5");
            Stack myStack = new Stack(5);
            Console.WriteLine("Pushing node of value 10 onto stack");
            myStack.Push(10);
            Console.WriteLine("Calling Peek(): " + myStack.Peek());
            Console.WriteLine("Calling Pop()");
            myStack.Pop();
            Console.WriteLine("Calling Peek(): " + myStack.Peek());

            Console.WriteLine("\nTesting Queues!\n");
            Console.WriteLine("Creating new queue with one node value of 5");
            Queue myQueue = new Queue(5);
            Console.WriteLine("Enqueuing node of value 10 into queue");
            myQueue.Enqueue(10);
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());
            Console.WriteLine("Calling Dequeue()");
            myQueue.Dequeue();
            Console.WriteLine("Calling Peek(): " + myQueue.Peek());

            Console.ReadLine();
        }
    }
}
