using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Example1.Revised
{
    public class OutputProcessor
    {
        private readonly string _separator;

        public OutputProcessor(string separator)
        {
            _separator = separator;
        }

        public void PrintNumber(int number)
        {
            Console.Write(number);
            Console.Write(_separator);
        }

        public void PrintLastNumber(int number)
        {
            Console.WriteLine(number);
        }
    }
}
