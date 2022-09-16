// Напишите программу, которая на вход принимает число и выдаёт его квадрат 
//(число умноженное на само себя).
//4 -> 16 
//-3 -> 9 
//-7 -> 49

Console.Clear();

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("Квадрата числа " + number + " равен " + number * number);

Console.WriteLine("Квадрата числа " + number + " равен " + Math.Pow(number, 2));


