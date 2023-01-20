using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomListWorkshop
{

    class StartUp
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list.Contains(5));
            list.Swap(0, 3);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}