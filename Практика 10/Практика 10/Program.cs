using System;

namespace Практика_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] threeDimensionalArray = new int[3, 3, 3];
            int count = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        threeDimensionalArray[i, j, k] = count;
                        count++;
                        if (count > 9)
                            count = 1;
                        Console.Write(threeDimensionalArray[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
