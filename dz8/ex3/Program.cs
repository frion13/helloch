// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

int[,] array1 = FillArray(rowCount, columnCount, 1, 10);
int[,] array2 = FillArray(rowCount, columnCount, 1, 10);
int[,] array3 = FillArray(rowCount, columnCount, 1, 10);
Console.WriteLine("Первый массив:");
PrintArray(array1);
Console.WriteLine("Второй массив:");
PrintArray(array2);
ProizMatrix(array1, array2, array3);
Console.WriteLine("Поизведение двух массивов:");
PrintArray(array3);




int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
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


void ProizMatrix(int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int x = 0;
            {
                x = array1[i, j] * array2[i, j];
            }
            array3[i, j] = x;
        }
    }
}