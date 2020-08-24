using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                    break;

                var position = int.Parse(line) - 2;

                var first = 0;
                var second = 1;

                Console.Write(first);
                Console.Write(" ");
                Console.Write(second);
                Console.Write(" ");

                for (var i = 0; i < position; i++)
                {
                    var temp = second;
                    second = first + second;
                    first = temp;

                    Console.Write(second);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
