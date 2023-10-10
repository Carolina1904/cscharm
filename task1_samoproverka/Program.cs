/*
Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
*/

System.Console.WriteLine("Write first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Write second number ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber < secondNumber)
{
    System.Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
}
else if(secondNumber < firstNumber)
{
    System.Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
}
else if(firstNumber == secondNumber)
{
    System.Console.WriteLine($"Введенные числа равны {firstNumber}");
}