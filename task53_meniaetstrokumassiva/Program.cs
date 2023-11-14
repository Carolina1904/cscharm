/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
*/ 

/*int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end+1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void PrintArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1000);
        System.Console.Write(arr[i] + "\t");
    }
    Console.ResetColor();
}

int[,] CopyArray(int[,] array)
{
    int[,] result = new int [array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++);
        {
            result[i,j];
        }
    }
    return result;
}


int[,] ChangeRows(int[,] array)
{
    int temperary = 0;
    int[,] result = new int[array.GetLength(0),arrayGetLength(1)];
    int[,] result = CopyArray(array);
    for (int j = 0; j < array.GetLength(1); j++)
        {
            temperary = result[0,j];
            result[0,j]= result[array.GetLength(0),j];
            result[array.GetLength(0),j] = temperary;
        }
        return result;
    }




int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
System.Console.WriteLine();
int[,] userArray2 = ChangeRows(user2DArray);
Print2DArray(userArray2);*/


Console.Clear();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
void SwapFirstAndLastRow(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            int tmp = arr[0, j];
            arr[0, j] = arr[rows - 1, j];
            arr[rows - 1, j] = tmp;
        }
    }

int[,] array2D = new int[3, 4];
FillArray(array2D);
Print2DArray(array2D);
SwapFirstAndLastRow(array2D);
System.Console.WriteLine();
Print2DArray(array2D);