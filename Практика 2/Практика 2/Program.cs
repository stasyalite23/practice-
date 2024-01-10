using System;
using System.Collections.Generic;

class Fish
{
    public string Type { get; set; }
    public string Species { get; set; }
    public string Location { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list to store the fish
        List<Fish> fishList = new List<Fish>();

        // Add the fish that arrived at the warehouse
        fishList.Add(new Fish { Type = "Лосось", Species = "Атлантический Лосось", Location = "Бак 1" });
        fishList.Add(new Fish { Type = "Тунец", Species = "Желтоперый Тунец", Location = "Бак 2" });
        fishList.Add(new Fish { Type = "Треска", Species = "Атлантическая Треска", Location = "Бак 3" });

        // Display the fish and their locations
        foreach (Fish fish in fishList)
        {
            Console.WriteLine($"Type: {fish.Type}, Species: {fish.Species}, Location: {fish.Location}");
        }
    }
}
