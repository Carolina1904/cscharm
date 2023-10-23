/*
Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

Console.WriteLine("Введите длины трех сторон треугольника:");
Console.Write("Сторона A: ");
double sideA = double.Parse(Console.ReadLine());

Console.Write("Сторона B: ");
double sideB = double.Parse(Console.ReadLine());

Console.Write("Сторона C: ");
double sideC = double.Parse(Console.ReadLine());

bool isTriangle = IsTriangle(sideA, sideB, sideC);
{
    if (isTriangle)
        {
            Console.WriteLine("Треугольник с такими сторонами существует.");
        }
        else
        {
            Console.WriteLine("Треугольник с такими сторонами не существует.");
        }
}
bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
