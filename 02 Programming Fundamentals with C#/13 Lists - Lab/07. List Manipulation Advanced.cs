using System;
using System.Linq;
using System.Collections.Generic;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Boolean isModified = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        isModified= true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1]));
                        isModified = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        isModified = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        isModified = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(tokens[1]))) 
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        foreach (int number in numbers)
                        {
                            if (number % 2 == 0)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        foreach (int number in numbers)
                        {
                            if (number % 2 != 0)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        foreach (int number in numbers)
                        {
                            switch (tokens[1]) 
                            {
                                case "<":
                                    if (number < int.Parse(tokens[2]))
                                    {
                                        Console.Write(number + " ");
                                    }
                                    break;
                                case ">":
                                    if (number > int.Parse(tokens[2]))
                                    {
                                        Console.Write(number + " ");
                                    }
                                    break;
                                case ">=":
                                    if (number >= int.Parse(tokens[2]))
                                    {
                                        Console.Write(number + " ");
                                    }
                                    break;
                                case "<=":
                                    if (number <= int.Parse(tokens[2]))
                                    {
                                        Console.Write(number + " ");
                                    }
                                    break;
                            }

                        }
                        Console.WriteLine();
                        break;
                }
            }
            if (isModified)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}   