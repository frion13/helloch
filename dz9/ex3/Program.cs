// Задача 68: Задайте значения M и N. 
// Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp;
Console.WriteLine("Наибольший общий делитель: " + maxNod( m,  n));


if (m < n)
{
    temp = m;
    m = n;
    n = temp;
}
int maxNod(int m, int n)
{
    if (n == 0)
        return m;
    else
        return maxNod(n, m % n);
}

