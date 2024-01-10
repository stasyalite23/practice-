using System;

namespace Практика_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 10;
            int denominator = 0;

            if (denominator == 0)
            {
                throw new DivideByZeroException("На нуль делить нельзя!");
            }

            int result = numerator / denominator;
        }
    }
}
