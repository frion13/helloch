﻿// Задача 65: Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

void recurs(int m, int n)
{
    if (m<=n)
    {
        int outp = m;
        m++;
        Console.Write(outp + ", ");
        recurs(m, n);

    }
    else return;
    
}
recurs(m, n);