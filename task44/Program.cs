//

Console.Write("Введите количество чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Пожалуйста, введите положительное число.");
    return;
}

int first = 0;
int second = 1;

Console.Write("Первые " + N + " чисел Фибоначчи: ");

if (N >= 1)
{
    Console.Write(first);
}

if (N >= 2)
{
    Console.Write(", " + second);
}

for (int i = 3; i <= N; i++)
{
    int next = first + second;
    Console.Write(", " + next);
    first = second;
    second = next;
}

Console.WriteLine();

