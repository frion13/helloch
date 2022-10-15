// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = FillArray(5, 100, 999);
int count = 0;

Console.WriteLine("[" + String.Join(",", array) + "]");


for (int j = 0; j < array.Length; j++)
    if (array[j] % 2 == 0)
        count++;
Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}