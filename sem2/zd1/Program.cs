﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

//78 -> 8 
//12-> 2 
//85 -> 8

Console.Clear();
int randomNum = new Random().Next(10, 99);

Console.WriteLine($"Число: {randomNum}");
int a1 = randomNum / 10;
int a2 = randomNum % 10;
// Console.WriteLine(a1, a2);
int max = a1;

if (a2>max)
{
  max = a2;
}
Console.WriteLine($"Макчимальная цифра {max} в числе {randomNum}");
