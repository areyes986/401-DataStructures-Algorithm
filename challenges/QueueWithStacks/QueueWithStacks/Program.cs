using QueueWithStacks.Classes;
using System;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EnqueuingAndDequeuing();
        }

        public static void EnqueuingAndDequeuing()
        {
            PsuedoQueue ps = new PsuedoQueue();
            ps.Enqueue(3);
            ps.Enqueue(4);
            ps.Enqueue(5);

            Console.WriteLine($"Peeking while enqueuing {ps.Stack1.Peek()}");

            ps.Dequeue();

            Console.WriteLine($"After Dequeuing {ps.Stack1.Peek()}");


        }
    }
}
