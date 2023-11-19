/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
*/


using System;

class Program
{
    static void Main()
    {
        // Задаем первую матрицу
        int[,] matrix1 = new int[3, 3];
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
              matrix1 [i, j] = new Random().Next(1, 10);
            }
        }
    }
    Console.WriteLine("Исходный первый массив:");
    PrintArray(matrix1);
        // Задаем вторую матрицу
        int[,] matrix2 = new int[3, 3];
    {
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
               matrix2 [i, j] = new Random().Next(1, 9);
            }
        }
    }
    Console.WriteLine("Исходный второй массив:");
    PrintArray(matrix2);

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
        // Находим произведение матриц
        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

        // Выводим результат на экран
        Console.WriteLine("Произведение матриц:");
        PrintMatrix(resultMatrix);
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Проверяем, можно ли умножить матрицы
        if (cols1 != rows2)
        {
            throw new InvalidOperationException("Невозможно выполнить умножение матриц");
        }

        // Создаем матрицу для хранения результата умножения
        int[,] resultMatrix = new int[rows1, cols2];

        // Выполняем умножение матриц
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
