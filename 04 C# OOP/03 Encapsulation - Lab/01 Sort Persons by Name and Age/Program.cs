﻿using System;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Person person = new Person(tokens[0], tokens[1], int.Parse(tokens[2]));
                persons.Add(person);
            }
            persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}