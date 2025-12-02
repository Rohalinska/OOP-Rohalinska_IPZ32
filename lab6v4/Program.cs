using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Lab 6: Lambda, Delegates — Variant 4 ===\n");

        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine($"Лямбда-додавання: 10 + 7 = {add(10, 7)}\n");

        Func<int, int, int> multiply = delegate (int a, int b)
        {
            return a * b;
        };
        Console.WriteLine($"Анонімна функція множення: 3 * 5 = {multiply(3, 5)}\n");

        List<int> numbers = new List<int> { 12, 5, 23, 44, 8, 19, 2, 31, 17 };
        Console.WriteLine("Початковий список:");
        Console.WriteLine(String.Join(", ", numbers) + "\n");

        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Парні числа:");
        Console.WriteLine(String.Join(", ", evenNumbers) + "\n");

        var sorted = numbers.OrderBy(n => n);
        Console.WriteLine("Відсортований список:");
        Console.WriteLine(String.Join(", ", sorted) + "\n");

        Func<List<int>, int> sumFunc = list => list.Sum();
        int total = sumFunc(numbers);
        Console.WriteLine($"Сума всіх чисел: {total}\n");

        var squares = numbers.Select(x => x * x);
        Console.WriteLine("Квадрати чисел:");
        Console.WriteLine(String.Join(", ", squares) + "\n");

        var greater10 = numbers.Where(x => x > 10);
        Console.WriteLine("Числа > 10:");
        Console.WriteLine(String.Join(", ", greater10) + "\n");

        int product = numbers.Aggregate(1, (acc, x) => acc * x);
        Console.WriteLine($"Добуток елементів: {product}");
    }
}
