using System;

namespace Практика_12__задача_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[5] { 6, 31, 1, 45, 54 };

            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = 0; j < values.Length - i - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}
