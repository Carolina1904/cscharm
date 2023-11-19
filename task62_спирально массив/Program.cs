/*
Задача 62: Заполните спирально массив 4 на 4.
*/ 

using System;

class Program
{
    static void Main()
    {
        int[,] array = FillSpiralArray(4, 4);

        // Выводим заполненный массив
        PrintArray(array);
    }

    static int[,] FillSpiralArray(int rows, int cols)
    {
        int[,] array = new int[rows, cols];
        int value = 1;

        int startRow = 0, endRow = rows - 1;
        int startCol = 0, endCol = cols - 1;

        while (startRow <= endRow && startCol <= endCol)
        {
            // Заполняем верхнюю строку
            for (int col = startCol; col <= endCol; col++)
            {
                array[startRow, col] = value++;
            }
            startRow++;

            // Заполняем правый столбец
            for (int row = startRow; row <= endRow; row++)
            {
                array[row, endCol] = value++;
            }
            endCol--;

            // Заполняем нижнюю строку
            if (startRow <= endRow)
            {
                for (int col = endCol; col >= startCol; col--)
                {
                    array[endRow, col] = value++;
                }
                endRow--;
            }

            // Заполняем левый столбец
            if (startCol <= endCol)
            {
                for (int row = endRow; row >= startRow; row--)
                {
                    array[row, startCol] = value++;
                }
                startCol++;
            }
        }

        return array;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
