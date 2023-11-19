/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/ 

System.Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от {number} до 1:");

void PrintNaturalNumbers(int number)
    {
        if (number < 1) return;
        else
        {
            Console.Write(number + " ");
            PrintNaturalNumbers(number - 1);
        }
    }

PrintNaturalNumbers(number);







