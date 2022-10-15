// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int size = 4;
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
double minNum = Int32.MaxValue;
double maxNum = Int32.MinValue;
Console.WriteLine("Массив: [" + String.Join(", ",numbers)+ "]");

for (int j = 0; j < numbers.Length; j++)
{

    
    if (numbers[j] > maxNum)
        {
            maxNum = numbers[j];
        }
    if (numbers[j] < minNum)
        {
            minNum = numbers[j];
        }
}

Console.WriteLine($"всего {numbers.Length} числа. Максимальное значение = {maxNum}, минимальное значение = {minNum}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {maxNum - minNum}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}




