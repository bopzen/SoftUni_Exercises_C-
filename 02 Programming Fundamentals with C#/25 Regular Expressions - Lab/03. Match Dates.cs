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
            string dates = Console.ReadLine();
            string pattern = @"\b(?<day>[\d]{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>[\d]{4})\b";
            Regex regex = new Regex(pattern);
            MatchCollection matchedDates = regex.Matches(dates);
            foreach (Match matchedDate in matchedDates)
            {
                string day = matchedDate.Groups["day"].Value;
                string month = matchedDate.Groups["month"].Value;
                string year = matchedDate.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}