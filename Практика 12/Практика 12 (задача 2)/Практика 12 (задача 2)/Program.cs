using System;

namespace Практика_12__задача_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacciArray = new int[10];
            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;

            for (int i = 2; i < 10; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];              
            }
            for (int i = 0; i < fibonacciArray.Length; i++)
            {
                Console.WriteLine(fibonacciArray[i]);
            }
        }
    }
}
