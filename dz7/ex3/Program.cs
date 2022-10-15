// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int col = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(row, col, 1, 10);
double[] averageArray = new double[col];

Console.WriteLine("Получившийся массив:");
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / row;
    avarage = Math.Round(avarage,2);
    Console.Write(avarage + "; ");
}




double[,] FillArray(int rows, int columns, int min, int max)
{
    double[,] filledArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);

        }
        Console.WriteLine();

    }
}