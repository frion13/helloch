// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.


Console.Clear();
int Number1 = new Random().Next(10, 100);
int Number2 = new Random().Next(1, 10);

Console.WriteLine($"Число: {Number1}");
Console.WriteLine($"Число: {Number2}");


int result = 0;
if (result == Number1 % Number2)
{

  System.Console.WriteLine($"Число {Number1} кратен числу {Number2}");
}
else
{
  System.Console.WriteLine($"остатот от деления равен {Number1 % Number2}");
};



