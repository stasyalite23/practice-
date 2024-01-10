using System;

class Fish
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public float Size { get; set; }

    public Fish(string name, string type, string color, float size)
    {
        Name = name;
        Type = type;
        Color = color;
        Size = size;
    }

    public void PrintFishDetails()
    {
        Console.WriteLine($"Имя рыбки: {Name}");
        Console.WriteLine($"Вид рыбки: {Type}");
        Console.WriteLine($"Окрас рыбки: {Color}");
        Console.WriteLine($"Размер рыбки: {Size} дюйма");
    }
}

class Program
{
    static void Main()
    {
        // Create a new fish object
        Fish myFish = new Fish("Немо", "Рыба-клоун", "Оранжевый", 3.5f);

        // Print the fish details
        myFish.PrintFishDetails();

        // Update the fish name
        myFish.Name = "Дори";

        // Print the updated fish details
        myFish.PrintFishDetails();
    }
}
