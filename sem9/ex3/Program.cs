// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр с помощью рекурсии.
// 453 -> 12
// 45 -> 9



Console.Clear();
Console.Write("Введите натуральное число: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());


int SumDigitsViaRecursion(int number)
{
   if (number > 0)
   {
        return number % 10 + SumDigitsViaRecursion(number / 10);
   }
   else return 0;
}
int result = SumDigitsViaRecursion(naturalNumber);
Console.WriteLine($"{naturalNumber} -> ({result})");
Console.WriteLine();


