/*
Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования
*/


using System;
int[] originalArray = { 1, 2, 3, 4, 5 };
int[] copiedArray = new int[originalArray.Length];

for (int i = 0; i < originalArray.Length; i++) // Копируем элементы из исходного массива в новый массив
{
    copiedArray[i] = originalArray[i];
}

Console.WriteLine("Исходный массив: " + string.Join(", ", originalArray));
Console.WriteLine("Копия массива: " + string.Join(", ", copiedArray));