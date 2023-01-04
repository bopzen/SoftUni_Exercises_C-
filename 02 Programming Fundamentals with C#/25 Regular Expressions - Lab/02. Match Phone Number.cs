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
            string numbers = Console.ReadLine();
            string pattern = @"\+359([ |-])[2]\1[\d]{3}\1[\d]{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matchedPhones = regex.Matches(numbers);
            string[] phones = matchedPhones.Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}