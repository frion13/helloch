// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 1011013 -> 112 -> 10




Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"В двоичной системе: {ConvertTo2(num)}");

string ConvertTo2(int num_local)
{
string s = "";
while (num_local > 0)
{
s = ((num_local % 2 == 0) ? "0" : "1") + s;
num_local /= 2;
}
if (s == "") s = "0";
return s;
}
