namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            List<string> words = new List<string>();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            char[] splitSymbols = { ' ', '.', ',', '-', '?', '!', ':', ';' };
            using (StreamReader reader = new StreamReader(wordsFilePath)) 
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] wordsArray = line.ToLower().Split(splitSymbols);
                    foreach (string word in wordsArray)
                    {
                        words.Add(word);
                    }
                }
            }

            using (StreamReader reader = new StreamReader(textFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] wordsArray = line.ToLower().Split(splitSymbols);
                    foreach (string listWord in words)
                    {
                        foreach (string word in wordsArray)
                        {
                            if (listWord == word.ToLower())
                            {
                                if (!wordsCount.ContainsKey(word))
                                {
                                    wordsCount.Add(word, 0);
                                }
                                wordsCount[word]++;
                            }
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var item in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
