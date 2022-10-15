using System;

//Напишите прогу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int x = int.Parse(System.Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("x>0, y>0");
}
else if (x == 2)
{
    Console.WriteLine("x<0, y>0");
}
else if (x == 3)
{
    Console.WriteLine("x<0, y<0");
}
else if (x == 4)
{
    Console.WriteLine("x>0, y<0");
}
else
{
    Console.WriteLine("Вы ввели неверную четверть");
}