using System;

class Program
{
    static void Main()
    {
        double initialWater = 2000; // Initial amount of water in liters (2 tons)
        double waterSpent = 500; // Amount of water spent on fish in liters

        Console.WriteLine("Изначальный объем воды: " + initialWater + " литров");
        Console.WriteLine("Использованный объем воды: " + waterSpent + " литров");

        double remainingWater = initialWater - waterSpent;
        Console.WriteLine("Оставшийся объем воды: " + remainingWater + " литров");

        double waterReceived;
        do
        {
            Console.Write("Введите объем добавляемой воды (в литрах): ");
        } while (!double.TryParse(Console.ReadLine(), out waterReceived) || waterReceived < 0 || remainingWater + waterReceived > 2000);

        Console.WriteLine("Добавленный объем воды: " + waterReceived + " литров");

        double finalWater = remainingWater + waterReceived;
        Console.WriteLine("Итоговый объем воды: " + finalWater + " литров");
    }
}
