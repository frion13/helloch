// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N


Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int count = 1;
while (n >= count)
{
  if (count % 2 == 0)
  {
    Console.Write(count + " ");
  }
  count++;
}




