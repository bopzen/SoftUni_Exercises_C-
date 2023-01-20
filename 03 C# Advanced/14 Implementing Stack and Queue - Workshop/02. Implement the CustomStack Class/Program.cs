using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomStackWorkshop
{

    class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            Console.Write(stack.Peek());
            stack.ForEach(x => Console.WriteLine(x));
        }
    }
}