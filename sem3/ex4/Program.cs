using System;

//Напишите программу, которая принимает на вход число(N) и выдает таблицу квадратов чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите Число: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine (Math.Pow(i, 2));
}

