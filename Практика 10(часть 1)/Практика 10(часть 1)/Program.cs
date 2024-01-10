using System;
using System.Collections.Generic;

public class Village : IComparable<Village>
{
    private int population;
    private int area;

    public Village(int population, int area)
    {
        this.population = population;
        this.area = area;
    }

    public int Population
    {
        get { return population; }
    }

    public int Area
    {
        get { return area; }
    }

    public void Multiply(int factor)
    {
        population *= factor;
        area *= factor;
    }

    public Village Stack(Village other)
    {
        int stackedPopulation = population + other.population;
        int stackedArea = area + other.area;
        return new Village(stackedPopulation, stackedArea);
    }

    public int CompareTo(Village other)
    {
        return population.CompareTo(other.population);
    }

    public override string ToString()
    {
        return $"Население: {population}, Площадь: {area}";
    }

    public static void Main(string[] args)
    {
        Village komarovo = new Village(100, 50);
        Village byazevo = new Village(200, 75);
        Village titarovka = new Village(150, 60);
        Console.WriteLine();

        // Multiplication
        komarovo.Multiply(2);
        Console.WriteLine("Результат увеличения деревни Комарово в 2 раза: " + komarovo);

        // Stacking
        Village stackedVillage = komarovo.Stack(byazevo);
        Console.WriteLine("Результат сложения увеличенной в 2 раза деревни Комарово и деревни Бязево: " + stackedVillage);

        // Comparison
        List<Village> villages = new List<Village> {komarovo, byazevo, titarovka };
        villages.Sort();
        Console.WriteLine("Результат сортировки деревень по количеству населения и площади:");
        foreach (Village village in villages)
        {
            Console.WriteLine(village);
        }
    }
}
