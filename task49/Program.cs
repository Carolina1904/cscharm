/*

*/

Console.Clear();
int[,] GetRandomArray(int strg, int stlb)
{
    int[,] array = new int[strg, stlb];
    for (int i = 0; i < strg; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");

        }
        System.Console.WriteLine();
    }
}
int[,] Square(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i +=2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
            {
                arr[i, j] *= 2;
            }
        }
        return arr;
}
System.Console.WriteLine("Введите кол-во строк: ");
int userStrg = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-то столбцов: ");
int userStlb = Convert.ToInt32(Console.ReadLine());
int[,] userArray = GetRandomArray(userStrg, userStlb);
PrintArray(userArray);
System.Console.WriteLine();
int[,] userSquare = Square(userArray);
PrintArray(userSquare);
System.Console.WriteLine();
PrintArray(userArray);