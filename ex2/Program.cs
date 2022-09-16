Console.Clear();
Console.Write("Введите первое число: ");
Console.Write("Введите второе число: ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a==b*b)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");
}
