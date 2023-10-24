/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/


/*Console.WriteLine("Введите параметры первой прямой:");
Console.Write("Значение k1: ");
if (!double.TryParse(Console.ReadLine(), out double k1))
{
    Console.WriteLine("Некорректный ввод для k1.");
    return;
}

Console.Write("Значение b1: ");
if (!double.TryParse(Console.ReadLine(), out double b1))
{
    Console.WriteLine("Некорректный ввод для b1.");
    return;
}

Console.WriteLine("Введите параметры второй прямой:");
Console.Write("Значение k2: ");
if (!double.TryParse(Console.ReadLine(), out double k2))
{
    Console.WriteLine("Некорректный ввод для k2.");
    return;
}

Console.Write("Значение b2: ");
if (!double.TryParse(Console.ReadLine(), out double b2))
{
    Console.WriteLine("Некорректный ввод для b2.");
    return;
}

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны, нет точки пересечения.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: ({x}, {y})");
}*/



Console.WriteLine("Введите параметры первой прямой:");
Console.Write("Значение k1: ");
if (!double.TryParse(Console.ReadLine(), out double k1))
{
    Console.WriteLine("Некорректный ввод для k1.");
    return;
}

Console.Write("Значение b1: ");
if (!double.TryParse(Console.ReadLine(), out double b1))
{
    Console.WriteLine("Некорректный ввод для b1.");
    return;
}

Console.WriteLine("Введите параметры второй прямой:");
Console.Write("Значение k2: ");
if (!double.TryParse(Console.ReadLine(), out double k2))
{
    Console.WriteLine("Некорректный ввод для k2.");
    return;
}

Console.Write("Значение b2: ");
if (!double.TryParse(Console.ReadLine(), out double b2))
{
    Console.WriteLine("Некорректный ввод для b2.");
    return;
}

// Расчет точки пересечения через массив
double[] intersection = CalculateIntersection(k1, b1, k2, b2);

if (intersection != null)
{
    Console.WriteLine($"Точка пересечения: ({intersection[0]}, {intersection[1]})");
}
else
{
    Console.WriteLine("Прямые параллельны, нет точки пересечения.");
}


double[] CalculateIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        return null; // Прямые параллельны
    }

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    return new double[] { x, y };
}