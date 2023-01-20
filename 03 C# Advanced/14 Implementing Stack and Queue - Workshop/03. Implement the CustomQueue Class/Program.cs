using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomQueueWorkshop
{

    class StartUp
    {
        static void Main(string[] args)
        {
            CustomQueue queue = new CustomQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);              
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}