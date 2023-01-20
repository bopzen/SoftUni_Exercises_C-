namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<string> bytesList = new List<string>();
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                while (!reader.EndOfStream)
                {
                    bytesList.Add(reader.ReadLine());
                }
            }
            byte[] binaryBytes = File.ReadAllBytes(binaryFilePath);

            List<byte> foundBytes = new List<byte>();
            foreach (byte b in binaryBytes)
            {
                if (bytesList.Contains(b.ToString()))
                {
                    foundBytes.Add(b);
                }
            }

            File.WriteAllBytes(outputPath, foundBytes.ToArray());
        }
    }
}
