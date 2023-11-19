/*
67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/ 

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int intN(int n)
{
    if (n % 10 > 0) return n % 10 + intN(n / 10);
    else
        return 0;
}

int result = intN(number);
System.Console.WriteLine(result);

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = SumOfDigits(number);

        Console.WriteLine($"Сумма цифр числа {number}: {sum}");
    }

    static int SumOfDigits(int n)
    {
        // Базовый случай: если число состоит из одной цифры, возвращаем это число
        if (n < 10)
        {
            return n;
        }

        // Рекурсивный случай: суммируем последнюю цифру числа с суммой оставшихся цифр
        return n % 10 + SumOfDigits(n / 10);
    }
}*/
