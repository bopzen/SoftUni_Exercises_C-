namespace SplitMergeBinaryFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] allBytes = File.ReadAllBytes(sourceFilePath);
            List<byte> bytes1 = new List<byte>();
            List<byte> bytes2 = new List<byte>();
            int length = allBytes.Length;
            int half = length / 2;
            for (int i = 0; i < length - half; i++)
            {
                bytes1.Add(allBytes[i]);
            }
            for (int i = length - half; i < length; i++)
            {
                bytes2.Add(allBytes[i]);
            }
            File.WriteAllBytes(partOneFilePath, bytes1.ToArray());
            File.WriteAllBytes(partTwoFilePath, bytes2.ToArray());
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream reader1 = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream reader2 = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (FileStream writer = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
                    {
                        reader1.CopyTo(writer);
                        reader2.CopyTo(writer);
                    }
                }
            }
        }
    }
}