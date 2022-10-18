// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат: ");
recursion();

void recursion() {
if (N > 0) {
int outp = N;
N--;
recursion();
Console.Write(" " + outp);
}
return;
}
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine(i);
// }