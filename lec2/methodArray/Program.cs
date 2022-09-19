int[] array = {12, 2, 344, 3, 50, 86, 2, 700, 118};
int n = array.Length;  
int find = 2;

int index = 0;

while (index<n)
{ if (array[index] == find)
{
    Console.WriteLine(index);
    break;
  }
  index = index + 1;
}