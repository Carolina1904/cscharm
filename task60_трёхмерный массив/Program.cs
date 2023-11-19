/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/ 

using System;

class Program
{
    static void Main()
    {
        // Формируем трехмерный массив из неповторяющихся двузначных чисел
        int[,,] threeDimensionalArray = GenerateArray();

        // Выводим массив с добавлением индексов
        PrintArrayWithIndexes(threeDimensionalArray);
    }

    static int[,,] GenerateArray()
    {
        int[,,] array = new int[1,2,3];
        int currentValue = 10; // Начинаем с двузначного числа 10

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = currentValue;
                    currentValue++;
                }
            }
        }

        return array;
    }

    static void PrintArrayWithIndexes(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.WriteLine($"[{i}, {j}, {k}] = {array[i, j, k]}");
                }
            }
        }
    }
}
