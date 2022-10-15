
// Напишите программу, которая принимает на вход число и выдает количество цифр в числе

 Console.Clear();
 
 Console.WriteLine("Введите число: ");
 int  num= int.Parse(Console.ReadLine());
 string anyNum = Convert.ToString(num);
 int lenght = anyNum.Length;

 Console.WriteLine(lenght);
