// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();

int[] array = FillArray(4, -10, 100);
int sum = 0;
Console.WriteLine("Массив [" + String.Join(",", array) + "]");







int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);

    }

    
    return filledArray;
}


for (int z = 1; z < array.Length; z+=2)
    sum = sum + array[z];
Console.WriteLine("Сумма нечетных элементов = " + sum);
    