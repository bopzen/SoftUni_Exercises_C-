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

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                bool studentExists = false;
                foreach (Student student in studentsList)
                {
                    if (firstName == student.FirstName && lastName == student.LastName)
                    {
                        studentExists = true;
                        student.Age = age;
                        student.HomeTown = homeTown;
                        break;
                    }
                }

                if (!studentExists)
                {
                    Student newStudent = new Student();
                    newStudent.FirstName = firstName;
                    newStudent.LastName = lastName;
                    newStudent.Age = age;
                    newStudent.HomeTown = homeTown;
                    studentsList.Add(newStudent);
                }
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