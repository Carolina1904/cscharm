/*
 Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
 Выведите полученный массив на экран.
*/
/*int m = 3; 
int n = 4;
// Создайте двумерный массив
int[,] array = new int[m, n];

// Заполните массив согласно формуле 
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = i + j;
    }
}

// Выведите массив на экран
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t"); // Используем \t для разделения элементов
    }
    Console.WriteLine(); // Переход на новую строку после каждой строки массива
}*/


Console.Clear();
int[,] GetRandomArray(int strg, int stlb)
{
    int[,] array = new int[strg, stlb];
    for (int i = 0; i < strg; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    
    for (int i = 0; i <arr.GetLength(0) ; i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j]+ "\t");
           
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