Console.Write("Введите имя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
   Console.WriteLine("Ура, рад тебя видеть");   
}
else
{
   Console.Write("привет,");
   Console.WriteLine(username);
}

