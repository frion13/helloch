// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
int Number = new Random().Next(1, 99999);
Console.WriteLine($"Дано число: {Number}");
string anyNumberText = Convert.ToString(Number);
if (anyNumberText.Length > 2)
{
  Console.WriteLine($"Третьей цифрой числа {Number} является цифра {anyNumberText[2]}");
}
else
{
  Console.WriteLine($"у числа {Number} нет третьей цифры");
}

