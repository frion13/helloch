//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Clear();
Console.WriteLine("Введите первое число: ");
Console.WriteLine("Введите второе число: ");
Console.WriteLine("Введите третье число: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a > b)
{
  Console.WriteLine("Максимальное число " + (a));
}
 else if (b>c)
 {
  Console.WriteLine("Максимальное число " + (b));
 }
else
{
  Console.WriteLine("Максимальное число " + (c)); ;
}
