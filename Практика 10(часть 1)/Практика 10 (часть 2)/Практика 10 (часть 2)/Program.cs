using System;

public class MyArray
{
    private int[] elements;

    public MyArray(int[] elements)
    {
        this.elements = elements;
    }

    public MyArray Add(MyArray other)
    {
        int maxLength = Math.Max(elements.Length, other.elements.Length);
        int[] result = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            int a = i < elements.Length ? elements[i] : 0;
            int b = i < other.elements.Length ? other.elements[i] : 0;
            result[i] = a + b;
        }

        return new MyArray(result);
    }

    public MyArray Subtract(MyArray other)
    {
        int maxLength = Math.Max(elements.Length, other.elements.Length);
        int[] result = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            int a = i < elements.Length ? elements[i] : 0;
            int b = i < other.elements.Length ? other.elements[i] : 0;
            result[i] = a - b;
        }

        return new MyArray(result);
    }

    public MyArray Multiply(MyArray other)
    {
        int maxLength = Math.Max(elements.Length, other.elements.Length);
        int[] result = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            int a = i < elements.Length ? elements[i] : 0;
            int b = i < other.elements.Length ? other.elements[i] : 0;
            result[i] = a * b;
        }

        return new MyArray(result);
    }

    public MyArray Divide(MyArray other)
    {
        int maxLength = Math.Max(elements.Length, other.elements.Length);
        int[] result = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            int a = i < elements.Length ? elements[i] : 0;
            int b = i < other.elements.Length ? other.elements[i] : 1; // Avoid division by zero
            result[i] = a / b;
        }

        return new MyArray(result);
    }

    public MyArray Remainder(MyArray other)
    {
        int maxLength = Math.Max(elements.Length, other.elements.Length);
        int[] result = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            int a = i < elements.Length ? elements[i] : 0;
            int b = i < other.elements.Length ? other.elements[i] : 1; // Avoid division by zero
            result[i] = a % b;
        }

        return new MyArray(result);
    }

    public void Print()
    {
        Console.WriteLine(string.Join(", ", elements));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyArray array1 = new MyArray(new int[] { 1, 2, 3 });
        MyArray array2 = new MyArray(new int[] { 4, 5 });

        MyArray sum = array1.Add(array2);
        sum.Print(); // Output: 5, 7, 3

        MyArray difference = array1.Subtract(array2);
        difference.Print(); // Output: -3, -3, 3

        MyArray product = array1.Multiply(array2);
        product.Print(); // Output: 4, 10, 0

        MyArray quotient = array1.Divide(array2);
        quotient.Print(); // Output: 0, 0, 3

        MyArray remainder = array1.Remainder(array2);
        remainder.Print(); // Output: 1, 2, 0
    }
}
