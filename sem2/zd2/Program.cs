//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

Console.Clear();
int Number = new Random().Next(100, 999);

Console.WriteLine($"Число: {Number}");
int newNumber = Number / 100 * 10 + Number % 10;


System.Console.WriteLine($"Число {newNumber} при удалении второй цифры из {Number}");
System.Console.WriteLine();
