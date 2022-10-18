// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N 
//  с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void recurs(int m, int n)
{
    if (m <= n)
    {
        int outp = m;
        m++;
        { 
            sum = sum + outp;
        }
        recurs(m, n);
    }
    else return ;
}
recurs(m, n);
Console.Write("Сумма натуральных элементов равна  " + sum);

