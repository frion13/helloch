

Console.Clear();
Console.Write("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
  Console.WriteLine(" понедельник");
}
else if (day == 2)
{
  Console.WriteLine(" вторник");
}
else if (day == 3)
{
  Console.WriteLine(" средв");
}
else if (day == 4)
{
  Console.WriteLine(" четверг");
}
else if (day == 5)
{
  Console.WriteLine(" пятница");
}
else if (day == 6)
{
  Console.WriteLine(" субботв");
}
else if (day == 7)
{
  Console.WriteLine(" воскресенье");
}
else
{
  Console.WriteLine(" введите число от 1 до 7");
}
  





