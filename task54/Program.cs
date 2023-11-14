/*
Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/

Console.Clear();

{
    // Создаем двумерный массив
    int[,] array = new int[3, 3];
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 50);
            }
        }
    }
    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    // Упорядочиваем элементы каждой строки по убыванию
    OrderRowsDescending(array);

    Console.WriteLine("Массив после упорядочивания:");
    PrintArray(array);
}

void OrderRowsDescending(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        // Преобразуем строку в одномерный массив
        int[] rowArray = new int[cols];
        for (int j = 0; j < cols; j++)
        {
            rowArray[j] = array[i, j];
        }

        // Сортируем одномерный массив по убыванию
        Array.Sort(rowArray, (a, b) => b.CompareTo(a));

        // Копируем отсортированные значения обратно в исходную строку
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rowArray[j];
        }
    }
}

static void PrintArray(int[,] array)
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


