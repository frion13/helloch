// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,1000);
    
}
string result = (string.Join(", ", arr));


Console.WriteLine($"[{result}]");
