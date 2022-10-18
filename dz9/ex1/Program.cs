// Задача 64: Задайте значения N и M. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N 
// с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8


Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

void recurs(int m, int n)
{
    if (m<=n)
    {
        int outp = m;
        m++;
        if (outp % 2 == 0)
        {
            Console.Write(outp + ", ");
        }
        recurs(m, n);
    }
    else return;
    
}
recurs(m, n);
