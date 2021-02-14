using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            //UC2
            stack.peekAndPopTillEmpty();

            //UC3
            Console.WriteLine("Enqueue Operation");
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();


        }
    }
}
