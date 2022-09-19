// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int Number = new Random().Next(99, 999);
Console.WriteLine($"Дано число: {Number}");
string anyNumberText = Convert.ToString(Number);
Console.WriteLine($"Второй цифрой числа {Number} является {anyNumberText[1]}");



