//Нпишите программу, которая принимает на вход координаты точки (Х и У), Х!=0 и У!=0 и выдает четверть плоскости  в которой находится эта точка

System.Console.WriteLine("Введите Х:");
int x = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите Y:");
int y = int.Parse(System.Console.ReadLine());

if (x>0 && y>0)
{
    System.Console.WriteLine("1");
} 

else if (x<0 && y>0)
{
    System.Console.WriteLine("2");
} 

else if (x<0 && y>0)
{
    System.Console.WriteLine("3");
} 

else{
    System.Console.WriteLine("4");
}