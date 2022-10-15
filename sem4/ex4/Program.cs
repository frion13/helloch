// напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядку

Console.Clear();
int n = 8;
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,2);
}
Console.WriteLine(string.Join(", ", arr));
