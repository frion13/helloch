// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
 
 Console.WriteLine("Введите число: ");
 string number = Console.ReadLine();

int sum = 0;
for(int i = 0; i < number.Length; i++)
{
    string temp = Convert.ToString(number[i]);

    sum += Convert.ToInt32(temp);
}

Console.WriteLine($"Сумма цифр в числе {number} = {sum}");

