// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.




Console.WriteLine("Введите число : ");
int num1 = Convert.ToInt32(Console.ReadLine());


if (num1 % 7 == 0 && num1 % 23 == 0)
{
  Console.WriteLine("Число {0} кратно числу 7 и 23", num1);
}
else if (num1 % 7 == 0)
{
  Console.WriteLine("Число {0} кратно 7 но не кратно 23", num1);
}
else if (num1 % 23 == 0)
{
  Console.WriteLine("Число {0} кратно 23 но не кратно 7", num1);
}
else
{
  Console.WriteLine("Число {0} не кратно числу 7 и 23", num1);
}