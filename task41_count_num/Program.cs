/*
 Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите количество чисел (M): ");
if (int.TryParse(Console.ReadLine(), out int M) && M > 0)
{
    double[] numbers = new double[M]; // Создаем массив для хранения чисел

    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            numbers[i] = number;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число заново.");
            i--; // Повторить ввод для данной итерации
        }
    }

    int count = 0; // Переменная для подсчета чисел больше 0

    for (int i = 0; i < numbers.Length; i++)
    {
        double number = numbers[i];

        if (number > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше 0: {count}");
}
else
{
    Console.WriteLine("Некорректное количество чисел. Пожалуйста, введите положительное целое число.");
}

/*int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}*/

