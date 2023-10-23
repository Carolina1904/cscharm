/*
39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами: 
1) менять числа местами в исходном массиве; 
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
*/ 


Console.Clear();
int[] GetRandArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int[] ReversArray(int[] arr)
{
    int temp = 0;

    for (int i = 0; i < arr.Length/2; i++)
    {
       temp = arr[i];
       arr[i] = arr[arr.Length -i-1];
       arr[arr.Length -i-1] = temp;

    }
    return arr;
}
int[] userArray = GetRandArray(0, 10, 5);
PrintArray(userArray);
System.Console.WriteLine();
int[] reversArray = ReversArray(userArray);
PrintArray(reversArray);