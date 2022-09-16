//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
Console.WriteLine("Введите второе число: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a>b)
{
  Console.WriteLine((a) + " больше " + (b) + " меньше"); 
}
else if (b>a)
{
  Console.WriteLine((b) + " больше " + (a) + " меньше ");
}
else
{
  Console.WriteLine("Числа равны");
}
