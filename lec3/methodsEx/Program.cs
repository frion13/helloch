using System;

string Method4(int count, string text)
{
    
    string result = String.Empty;

     for (int i = 0; i < count; i++)
     {
       result = result + text;
       i++; 
     }
    return result;
}

string res = Method4(10, "qwert");
// Console.WriteLine(res);

// Цикл в цикле, таблица умножения

for (int i = 1; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); 
    }
    Console.WriteLine();
}