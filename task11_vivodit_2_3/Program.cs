/*
Напишите программу которая выводит случайное трезназное число и удаляет вторую цифру этого числа
456->46
782->72
*/

int number = new Random().Next(100,1000);
System.Console.WriteLine(number);
int first = number / 100;
int last = number % 10;
System.Console.Write("answer = " + first + last);