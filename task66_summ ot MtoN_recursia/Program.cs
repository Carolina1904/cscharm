/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

System.Console.WriteLine("Enter first number : ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter second number : ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = intN(m, n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {sum}");

int intN(int m, int n)
{
    if (m > n)
    {
        return 0;
    }

    return m + intN(m + 1, n);
}