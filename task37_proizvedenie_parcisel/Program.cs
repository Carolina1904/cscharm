/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
using System;
Console.Clear();

int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] MultArray(int[] array) //[6 7 1 5 6 2 3 8] -> 48 21 2 30
{
    int[] result = new int[array.Length - array.Length / 2];
    int temp = 0;
    for (int i = 0; i < array.Length - array.Length / 2; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
            break; //заканчивает цикл
        }
        temp = array[i] * array[array.Length - 1 - i]; // первый элемент массива умножается на последний элемент и далее
        result[i] = temp;
    }
    return result;
}

int[] array = CreateArray(5, 1, 5);
Output(array);
System.Console.WriteLine();
int[] array2 = MultArray(array);
Output(array2);