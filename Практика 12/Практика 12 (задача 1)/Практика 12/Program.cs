using System;

namespace Практика_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { -20, 1, 51, -85, -9 };
            int positiveCount = 0;
            int negativeCount = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    negativeCount++;
                }
            }

            Console.WriteLine("Количество положительных чисел: " + positiveCount);
            Console.WriteLine("Количество отрицательных чисел: " + negativeCount);

        }
    }
}
