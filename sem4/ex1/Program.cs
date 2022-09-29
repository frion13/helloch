// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

 Console.Clear();
 
 Console.WriteLine("Введите число: ");
 int limit = int.Parse(Console.ReadLine());

 Console.WriteLine($"Результат суммы от 1 до {limit} = {GetSumToLimit(limit)}");

 int GetSumToLimit(int limit){

    int result = 0;
    for (int i = 0; i <= limit; i++)
    {
        result+=i;  
    }
    return result;
 }