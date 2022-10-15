// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


Console.WriteLine("Введите количество элементов: ");
int arr_length = int.Parse(Console.ReadLine());


int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)

    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

void PrintArray(int[] arr)
{
    Console.WriteLine(" [" + String.Join(",", arr) + "]");
}

void ChangeArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] filledArray1 = FillArray(arr_length, -10, 10);
Console.WriteLine("Размер массива: {0}", arr_length);
Console.WriteLine("Исходный массив: ");
PrintArray(filledArray1);
ChangeArr(filledArray1);
Console.WriteLine("Измененный массив: ");
PrintArray(filledArray1);