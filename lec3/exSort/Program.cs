
//Сортировка

int[] arr = {1, 5, 6, 7, 5, 8, 9, 1, 1, 1};
void ptintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
           
        }

        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}


void selectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
            
        }

        
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;

    }
}


ptintArray(arr);
selectionSort(arr);
ptintArray(arr);
selectionSortMax(arr);
ptintArray(arr);