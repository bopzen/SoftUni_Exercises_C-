namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader read = new StreamReader(inputFilePath))
            {
                using (StreamWriter write = new StreamWriter(outputFilePath))
                {
                    int row = 0;
                    while (!read.EndOfStream)
                    {
                        string line = read.ReadLine();
                        if (row %2 !=0)
                        {
                            write.WriteLine(line);
                        }
                        row++;
                    }
                }
            }
        }
    }
}
