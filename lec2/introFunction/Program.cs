

int Max(int arg1, int arg2, int arg3)
{ int result = arg1; 
  if (arg2>result) result = arg2;
  if (arg3>result) result = arg3;
  return result;
}



int a1 = 14;
int b1 = 67;
int c1 = 78;
int a2 = 400;
int b2 = 67;
int c2 = 77;
int a3 = 60;
int b3 = 2;
int c3 = 11111;

// int Max1 = Max(a1, b1, c1);
// int Max2 = Max(a2, b2, c2);
// int Max3 = Max(a3, b3, c3);

// int max = Max(Max1, Max2, Max3);   можно вызвать функцию так

// или так
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);


