/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до N:");

        PrintCubeTable(n);
    }

    static void PrintCubeTable(int n)
    {
        Console.WriteLine("Число\tКуб");
        Console.WriteLine("------------");

        for (int i = 1; i <= n; i++)
        {
            int cube = Cube(i);
            Console.WriteLine($"{i}\t{cube}");
        }
    }

    static int Cube(int x)
    {
        return x * x * x;
    }
}
