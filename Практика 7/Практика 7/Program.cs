using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class GoodsDistributionDevice
{
    private List<Product> products;
    private decimal depositedMoney;

    public GoodsDistributionDevice()
    {
        products = new List<Product>
        {
            new Product { Name = "Кола", Price = 70m, Quantity = 5 },
            new Product { Name = "Вода", Price = 50m, Quantity = 10 },
            new Product { Name = "Сок", Price = 65m, Quantity = 3 }
        };
        depositedMoney = 0;
    }

    public void DepositMoney(decimal amount)
    {
        depositedMoney += amount;
        Console.WriteLine($"Внесенная сумма: {depositedMoney} рублей");
    }

    public decimal GetChange()
    {
        decimal change = depositedMoney;
        depositedMoney = 0;
        Console.WriteLine($"Сдача: {change} рублей");
        return change;
    }

    public void BuyProduct(string productName, int quantity)
    {
        Product product = products.Find(p => p.Name == productName);
        if (product == null)
        {
            Console.WriteLine("Товар не найден");
            return;
        }

        if (product.Quantity < quantity)
        {
            Console.WriteLine("Недостаточное количество товара в автомате");
            return;
        }

        decimal totalCost = product.Price * quantity;
        if (depositedMoney < totalCost)
        {
            Console.WriteLine("Недостаточно средств");
            return;
        }

        product.Quantity -= quantity;
        depositedMoney -= totalCost;
        Console.WriteLine($"Совершена покупка товара: {productName} в количестве {quantity} штук  за {totalCost} рублей");
    }

    public void ShowAllCommands()
    {
        Console.WriteLine("Доступные команды:");
        Console.WriteLine("Внести <количество> рублей - Внести деньги");
        Console.WriteLine("Сдача - Получить сдачу");
        Console.WriteLine("Купить <Название товара> <Количество> - Купить товар");
        Console.WriteLine("Выход - Выйти из панели администратора");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GoodsDistributionDevice device = new GoodsDistributionDevice();
        bool isAdmin = false;

        while (true)
        {
            Console.Write("> ");
            string command = Console.ReadLine();

            if (isAdmin)
            {
                if (command == "Выход из панели администратора")
                { 
                    isAdmin = false;
                    Console.WriteLine("Осуществлен выход из панели администратора");
                }
                else
                {
                    // Handle admin commands here
                    Console.WriteLine("Панель администратора недоступна");
                }
            }
            else
            {
                if (command.StartsWith("Внести"))
                {
                    decimal amount = decimal.Parse(command.Split(' ')[1]);
                    device.DepositMoney(amount);
                }
                else if (command == "Сдача")
                {
                    device.GetChange();
                }
                else if (command.StartsWith("Купить"))
                {
                    string[] parts = command.Split(' ');
                    string productName = parts[1];
                    int quantity = int.Parse(parts[2]);
                    device.BuyProduct(productName, quantity);
                }
                else if (command == "Показать команды")
                {
                    device.ShowAllCommands();
                }
                else if (command == "Войти в панель администратора")
                {
                    isAdmin = true;
                    Console.WriteLine("Осуществлен вход в панель администратора");
                }
                else
                {
                    Console.WriteLine("Недопустимая команда");
                }
            }
        }
    }
}
