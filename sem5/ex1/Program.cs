// Задайте массив из 12 элементов, заполненнвй случайными числа из промежутка -9,9. Наидите сумму отрицательных и положительных элементов массива


Console.Clear();

int[] array = FillArray(12, -9, 9);

int positiveSum = 0;
int negativeSum = 0;

Console.WriteLine("[" + String.Join(",",array)+ "]");

foreach(int element in array){
positiveSum += element > 0 ? element : 0; //positiveSum += element -> // positiveSum = element + positiveSum
negativeSum += element < 0 ? element : 0;
}

Console.WriteLine("Положительные числа в массиве:" + positiveSum);
Console.WriteLine("Отрицательные числа в массиве:" + negativeSum);


int[] FillArray(int size, int min, int max)
{
int[] filledArray = new int[size];

for (int i = 0; i < filledArray.Length; i++)
{
filledArray[i] = new Random().Next(min, max + 1);
}
return filledArray;
}