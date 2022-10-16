// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
//  наименьшей суммой элементов: 1 строка




Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1, 10);
PrintArray(array);
findRow(array);


void findRow(int[,] array)
{
    if (rowCount == columnCount)
    {
        int minSum = 0;
        int sum = SumLine(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSum = SumLine(array, i);
            if (sum > tempSum)
            {
                sum = tempSum;
                minSum = i;
            }
        }
        Console.WriteLine($"Cтрока с наименьшей суммой элементов = {minSum + 1}. Сумма элементов  стоки = {sum}");
    }
    else
    {
        Console.WriteLine("Введен не прямоугольный массив!");
    }
}



int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}




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

