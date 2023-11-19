/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/ 

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = Power(a, b);

        Console.WriteLine($"{a}^{b} = {result}");
    }

    static int Power(int baseNumber, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else
        {
            return baseNumber * Power(baseNumber, exponent - 1);
        }
    }
}*/

System.Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int intN(int n1, int n2)
{
    if (n2 == 1) return n1;
    else
    return n1 * intN(n1, n2 -1);
}

int result = intN(number1, number2);
System.Console.WriteLine(result);
