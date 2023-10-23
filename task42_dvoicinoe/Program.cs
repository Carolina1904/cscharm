/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
*/
/*Console.Write("Введите десятичное число: ");
int decimalNumber = int.Parse(Console.ReadLine());

string binaryNumber = DecimalToBinary(decimalNumber);

Console.WriteLine($"Двоичное представление: {binaryNumber}");


string DecimalToBinary(int decimalNumber)
{
    return Convert.ToString(decimalNumber, 2);
}*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ToBool( int number)
{
    int result= 0;
    int count = 1;
    while (number>0)
    {
        result=number%2*count+result;
        number=number/2;
        count=count*10;
    }
return result;
}
int Number = ToBool(number);
Console.Write($"Двоичное представление {number} ->  " + Number );
