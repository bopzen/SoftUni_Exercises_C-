using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                Student student = new Student();
                student.FirstName = tokens[0];
                student.LastName = tokens[1];
                student.Age = int.Parse(tokens[2]);
                student.HomeTown= tokens[3];

                studentsList.Add(student);
            }

            string city = Console.ReadLine();

            foreach (Student student in studentsList)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}