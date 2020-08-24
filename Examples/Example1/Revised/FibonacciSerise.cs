using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Revised
{
    public class FibonacciSerise
    {
        private readonly int _first;
        private readonly int _second;
        private int _number1;
        private int _number2;

        public int FirstNumber
        {
            get { return _first; }
        }

        public int SecondNumber
        {
            get { return _second; }
        }

        public FibonacciSerise(int first, int second)
        {
            _first = first;
            _second = second;
            _number1 = _first;
            _number2 = _second;
        }

        public int Next()
        {
            var temp = _number2;
            _number2 = _number1 + _number2;
            _number1 = temp;
            return _number2;
        }

        public void Reset()
        {
            _number1 = _first;
            _number2 = _second;
        }
    }
}
