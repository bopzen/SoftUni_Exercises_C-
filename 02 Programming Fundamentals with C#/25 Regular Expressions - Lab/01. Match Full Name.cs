using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            MatchCollection matchedNames = regex.Matches(names);
            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}