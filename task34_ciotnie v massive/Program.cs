/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/ 

using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        Console.Write("Введите размер массива: ");
        int arraySize = int.Parse(Console.ReadLine());

        // Создаем массив и заполняем его случайными трехзначными числами
        int[] numbers = GenerateRandomNumbers(arraySize);

        // Выводим массив на экран
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(numbers);

        // Находим количество четных чисел в массиве
        int evenCount = CountEvenNumbers(numbers);

        // Выводим результат
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    // Метод для генерации случайных трехзначных чисел
    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100, 1000); // Генерируем случайное трехзначное число
        }

        return numbers;
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    // Метод для подсчета количества четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        return evenCount;
    }
}
