﻿/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/ 
System.Console.WriteLine("Введите 1 число : ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 7 == 0&& number1 % 23 == 0)
{
  System.Console.WriteLine("кратно ");  
}
else 
{
    System.Console.WriteLine("некратно ");
}


