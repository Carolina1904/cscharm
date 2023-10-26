/*
46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами
*/ 

/*int[,] GetRandomArray(int strg ,int stlb)
{
    int[,] array = new int[strg,stlb];
    for (int i = 0; i < strg; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}
void PrintArray(int[,] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
         System.Console.Write(arr[i ,j]+ "\t ");   
        }
         System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("enter kolicestvo strok: ");
System.Console.WriteLine("enter kolicestvo stolbtov: ");
int userStrg = Convert.ToInt32(Console.ReadLine());
int userStlg = Convert.ToInt32(Console.ReadLine());
int[,] userArray = GetRandomArray(userStrg,userStlg);*/

Console.Clear();
int[,] GetRandomArray(int strg, int stlb)
{
    int[,] array = new int[strg, stlb];
    for (int i = 0; i < strg; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            array[i, j] = new Random(). Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    System.Console.Write($"[ ]\t");
    int start = 0;
    for (int i = start; i < start + array.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"["+ i +"]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Введите кол-во строк: ");
int userStrg = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-то столбцов: ");
int userStlb = Convert.ToInt32(Console.ReadLine());
int[,] userArray = GetRandomArray(userStrg, userStlb);
PrintArray(userArray);