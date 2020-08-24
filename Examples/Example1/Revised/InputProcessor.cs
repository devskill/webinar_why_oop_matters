using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Revised
{
    public class InputProcessor
    {
        public int? ReadInput()
        {
            var line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
                return null;
            else
                return int.Parse(line);
        }
    }
}
