// Напишите программму, которая принимает на вход число M и N и выдает произведение чисел от M до N

 Console.Clear();
 
 Console.WriteLine("Введите число: N");
 int n = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите число: M");
 int m = int.Parse(Console.ReadLine());

 Console.WriteLine($"Результат произведения чисел от {n}  до {m} = {GetMult(n, m)}");

 


 int GetMult(int n, int m){

    if (n>m) 
 {
    int x = n;
     n = m;
     m = x;
 }

    int result = 1;
    for (int i = n; i <= m; i++)
    {
        result*=i;  
    }
    return result;
 }