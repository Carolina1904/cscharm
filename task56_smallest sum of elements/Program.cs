/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/


/*{
    // Создаем двумерный массив
    int[,] array = new int[3, 3];
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
               array [i, j] = new Random().Next(1, 50);
            }
        }
    }
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

 int FindRowWithMinSum(int[,] array2);
{
    int rows = array2.GetLength(0);
    int cols = array2.GetLength(1);

    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    for (int i = 0; i < rows; i++)
    {
        int currentSum = 0;

        // Считаем сумму элементов в текущей строке
        for (int j = 0; j < cols; j++)
        {
            currentSum += array[i, j];
        }

        // Сравниваем с текущей минимальной суммой
        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRowIndex = i;
        }
    }

    return minSumRowIndex;
}*/

using System;

class Program
{
    static void Main()
    {
        // Задаем размеры массива
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        // Создаем двумерный массив
        int[,] array = new int[rows, columns];

        // Заполняем массив случайными значениями
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 10); // Задайте диапазон случайных значений по вашему усмотрению
            }
        }

        // Выводим массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим строку с наименьшей суммой элементов
        int minSumRow = FindRowWithMinSum(array);

        // Выводим результат
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Метод для нахождения строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRow = 0;

        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < columns; j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRow = i;
            }
        }

        return minSumRow;
    }
}





