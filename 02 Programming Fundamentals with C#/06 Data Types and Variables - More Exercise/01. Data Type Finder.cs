using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                bool intTryParseIsSucceess = int.TryParse(input, out int intValue);
                bool doubleTryParseIsSuccess = double.TryParse(input, out double doubleValue);
                bool charTryParseIsSuccess = char.TryParse(input, out char charValue);
                bool boolTryParseIsSuccess = bool.TryParse(input, out bool boolValue);

                if (intTryParseIsSucceess)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (doubleTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (boolTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (charTryParseIsSuccess)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

            }
        }
    }
}
