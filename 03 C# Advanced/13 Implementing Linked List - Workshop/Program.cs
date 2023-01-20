using System;
using System.Linq;
using System.Collections.Generic;
 
namespace CustomDoublyLinkedList
{

    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            list.RemoveLast();
            list.RemoveFirst();
            list.ForEach(x => Console.Write(x + " "));
            Console.WriteLine(string.Join(", ", list.ToArray()));
        }
    }
}