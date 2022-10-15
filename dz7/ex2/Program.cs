// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int col = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(row, col, 1, 10);
Console.WriteLine("Получившийся массив:");
PrintArray(array);
checkArray(array);



void checkArray(int[,] array)
{   
    int index = array[n - 1, m - 1];
    
            if (n > array.GetLength(0) || m > array.GetLength(1))
            {
                Console.WriteLine("такого элемента нет");
            }
            else
            {
                Console.WriteLine($"значение элемента {n} строки и столбца {m}  равно {index}");
            }       
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